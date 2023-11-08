// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Product : AuditableEntity<int>
{
	public string      Title       { get; set; }
	public string      Description { get; set; }
	public Brand?      Brand       { get; set; }
	public List<Stock> Stock       { get; set; }
}