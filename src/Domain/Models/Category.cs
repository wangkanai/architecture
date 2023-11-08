// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Category : AuditableEntity<int>
{
	public string        Name     { get; set; }
	public Category?     Parent   { get; set; }
	public List<Product> Products { get; set; }
}