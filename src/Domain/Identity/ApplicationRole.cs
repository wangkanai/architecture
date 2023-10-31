﻿// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity;

namespace Wangkanai.Architecture.Identity;

public class ApplicationRole : IdentityRole<int>
{
	public string? Description { get; set; }

	public virtual List<ApplicationUserRole> Users { get; set; }
}