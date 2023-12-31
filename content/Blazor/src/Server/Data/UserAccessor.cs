// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using System.Security.Claims;

using Microsoft.AspNetCore.Identity;

using Wangkanai.Architecture.Identity;

namespace Wangkanai.Architecture.Data;

internal sealed class UserAccessor(
	IHttpContextAccessor         httpContextAccessor,
	UserManager<ApplicationUser> userManager,
	IdentityRedirectManager      redirectManager)
{
	public async Task<ApplicationUser> GetRequiredUserAsync()
	{
		ClaimsPrincipal? principal = httpContextAccessor.HttpContext?.User ??
		                             throw new InvalidOperationException(
			                             $"{nameof(GetRequiredUserAsync)} requires access to an {nameof(HttpContext)}.");

		ApplicationUser? user = await userManager.GetUserAsync(principal);

		if (user is null)
		{
			// Throws NavigationException, which is handled by the framework as a redirect.
			redirectManager.RedirectToWithStatus("/Account/InvalidUser",
				"Error: Unable to load user with ID '{userManager.GetUserId(principal)}'.");
		}

		return user;
	}
}