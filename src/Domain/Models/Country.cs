// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Country : Entity<int>
{
	public string Name      { get; set; }
	public string Iso       { get; set; }
	public ushort Extension { get; set; }
}