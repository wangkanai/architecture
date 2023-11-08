// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using System.Diagnostics;
using System.Security.Claims;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

using Wangkanai.Architecture.Client;
using Wangkanai.Architecture.Data;

namespace Wangkanai.Architecture.Identity;

public class PersistingRevalidatingAuthenticationStateProvider : RevalidatingServerAuthenticationStateProvider
{
	private readonly IServiceScopeFactory     _scopeFactory;
	private readonly PersistentComponentState _state;
	private readonly IdentityOptions          _options;

	private readonly PersistingComponentStateSubscription _subscription;

	private Task<AuthenticationState>? _authenticationStateTask;

	public PersistingRevalidatingAuthenticationStateProvider(
		ILoggerFactory            loggerFactory,
		IServiceScopeFactory      scopeFactory,
		PersistentComponentState  state,
		IOptions<IdentityOptions> options)
		: base(loggerFactory)
	{
		_scopeFactory = scopeFactory;
		_state        = state;
		_options      = options.Value;

		AuthenticationStateChanged += OnAuthenticationStateChanged;
		_subscription              =  state.RegisterOnPersisting(OnPersistingAsync, RenderMode.InteractiveWebAssembly);
	}

	protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);

	protected override async Task<bool> ValidateAuthenticationStateAsync(
		AuthenticationState authenticationState, CancellationToken cancellationToken)
	{
		// Get the user manager from a new scope to ensure it fetches fresh data
		await using AsyncServiceScope scope = _scopeFactory.CreateAsyncScope();
		UserManager<ApplicationUser>? userManager =
			scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
		return await ValidateSecurityStampAsync(userManager, authenticationState.User);
	}

	private async Task<bool> ValidateSecurityStampAsync(UserManager<ApplicationUser> userManager,
		ClaimsPrincipal                                                              principal)
	{
		ApplicationUser? user = await userManager.GetUserAsync(principal);
		if (user == null)
		{
			return false;
		}
		else if (!userManager.SupportsUserSecurityStamp)
		{
			return true;
		}
		else
		{
			string? principalStamp = principal.FindFirstValue(_options.ClaimsIdentity.SecurityStampClaimType);
			string? userStamp      = await userManager.GetSecurityStampAsync(user);
			return principalStamp == userStamp;
		}
	}

	private void OnAuthenticationStateChanged(Task<AuthenticationState> authenticationStateTask)
	{
		_authenticationStateTask = authenticationStateTask;
	}

	private async Task OnPersistingAsync()
	{
		if (_authenticationStateTask is null)
		{
			throw new UnreachableException(
				$"Authentication state not set in {nameof(RevalidatingServerAuthenticationStateProvider)}.{nameof(OnPersistingAsync)}().");
		}

		AuthenticationState? authenticationState = await _authenticationStateTask;
		ClaimsPrincipal?     principal           = authenticationState.User;

		if (principal.Identity?.IsAuthenticated == true)
		{
			string? userId = principal.FindFirst(_options.ClaimsIdentity.UserIdClaimType)?.Value;
			string? email  = principal.FindFirst(_options.ClaimsIdentity.EmailClaimType)?.Value;

			if (userId != null && email != null)
			{
				_state.PersistAsJson(nameof(UserInfo), new UserInfo { UserId = userId, Email = email });
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		_subscription.Dispose();
		AuthenticationStateChanged -= OnAuthenticationStateChanged;
		base.Dispose(disposing);
	}
}