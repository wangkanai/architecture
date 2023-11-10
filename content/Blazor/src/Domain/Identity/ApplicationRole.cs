// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationRole : IdentityRole<string>
{
	public string? Description { get; set; }

	public virtual List<ApplicationUserRole>  UserRoles  { get; set; }
	public virtual List<ApplicationRoleClaim> RoleClaims { get; set; }
}