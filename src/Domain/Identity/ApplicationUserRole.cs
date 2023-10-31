// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationUserRole : IdentityUserRole<string>
{
	public virtual ApplicationUser User { get; set; } = default!;
	public virtual ApplicationRole Role { get; set; } = default!;

}