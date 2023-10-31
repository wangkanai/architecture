// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Architecture.Authorization;

[Flags]
public enum ApplicationFeatures
{
	None     = 0,
	Pipeline = 1 << 0,
	Identity = 1 << 1,
	All      = ~None
}