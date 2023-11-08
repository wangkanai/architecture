// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationUser : IdentityUser<string>
{
	public string FirstName   { get; set; }
	public string MiddleName  { get; set; }
	public string LastName    { get; set; }
	public string DisplayName { get; set; }

	public virtual List<ApplicationUserClaim> UserClaims { get; set; }
	public virtual List<ApplicationUserRole>  UserRoles  { get; set; }
	public virtual List<ApplicationUserLogin> Logins     { get; set; }
	public virtual List<ApplicationUserToken> Tokens     { get; set; }
}