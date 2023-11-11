// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Unit : Entity<int>
{
	public string Name   { get; set; }
	public string Symbol { get; set; }
}