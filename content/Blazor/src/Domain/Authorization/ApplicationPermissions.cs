// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

namespace Wangkanai.Architecture.Authorization;

[Flags]
public enum ApplicationPermissions
{
	None   = 0,
	View   = 1 << 0,
	Edit   = 1 << 1,
	Delete = 1 << 2,
	All    = ~None
}