// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using System.Security.Claims;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Wangkanai.Architecture.Client;

public class PersistentAuthenticationStateProvider
	(PersistentComponentState persistentState) : AuthenticationStateProvider
{
	private static readonly Task<AuthenticationState> _unauthenticatedTask =
		Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));

	public override Task<AuthenticationState> GetAuthenticationStateAsync()
	{
		if (!persistentState.TryTakeFromJson<UserInfo>(nameof(UserInfo), out UserInfo? userInfo) || userInfo is null)
		{
			return _unauthenticatedTask;
		}

		Claim[] claims = [
			new Claim(ClaimTypes.NameIdentifier, userInfo.UserId),
			new Claim(ClaimTypes.Name, userInfo.Email),
			new Claim(ClaimTypes.Email, userInfo.Email)];

		return Task.FromResult(
			new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(claims,
				nameof(PersistentAuthenticationStateProvider)))));
	}
}