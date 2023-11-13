// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationUserClaim : IdentityUserClaim<string>
{
	public string Description { get; set; }

	public virtual ApplicationUser User { get; set; } = default!;
}