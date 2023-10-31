// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationUser : IdentityUser<string>
{
	public string Firstname  { get; set; }
	public string Middlename { get; set; }
	public string Lastname   { get; set; }

	public virtual List<ApplicationUserClaim> UserClaims { get; set; }
	public virtual List<ApplicationUserRole>  UserRoles  { get; set; }
	public virtual List<ApplicationUserLogin> Logins     { get; set; }
	public virtual List<ApplicationUserToken> Tokens     { get; set; }
}