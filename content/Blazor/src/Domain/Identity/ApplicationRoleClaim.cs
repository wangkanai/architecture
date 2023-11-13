// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationRoleClaim : IdentityRoleClaim<string>
{
	public string Description { get; set; }

	public virtual ApplicationRole Role { get; set; } = default!;
}