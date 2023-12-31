﻿// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Extensions;

namespace Wangkanai.Architecture.Authorization;

public static class ApplicationPermissionExtensions
{
	public static ApplicationPermissions[] GetAll => EnumValues<ApplicationPermissions>.GetValues();
}