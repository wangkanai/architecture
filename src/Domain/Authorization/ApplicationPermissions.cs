﻿// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Architecture.Authorization;

[Flags]
public enum ApplicationPermissions
{
	None   = 0,
	View   = 1,
	Edit   = 2,
	Delete = 4,
	All    = ~None
}