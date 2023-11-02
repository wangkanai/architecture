// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Architecture.Authorization;

[Flags]
public enum ApplicationFeatures
{
	None     = 0,
	Pipeline = 1 << 0,
	Contact  = 1 << 1,
	Activity = 1 << 2,
	Product  = 1 << 3,
	Identity = 1 << 4,
	All      = ~None
}