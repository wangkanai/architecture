// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Brand : AuditableEntity<int>
{
	public string        Name        { get; set; }
	public string?       Description { get; set; }
	public List<Product> Products    { get; set; }
}