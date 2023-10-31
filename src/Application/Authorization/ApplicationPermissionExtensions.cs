﻿// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Architecture.Authorization;
using Wangkanai.Extensions;

namespace Wangkanai.Architecture.Application.Authorization;

public static class ApplicationPermissionExtensions
{
	public static ApplicationPermissions[] GetAll => EnumValues<ApplicationPermissions>.GetValues();
}