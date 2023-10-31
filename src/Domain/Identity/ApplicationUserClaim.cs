// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationUserClaim : IdentityUserClaim<string>
{
	public string? Description { get; set; }

	public virtual ApplicationUser User { get; set; } = default!;
}