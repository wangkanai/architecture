// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Stock : AuditableEntity<int>
{
	public Product Product { get; set; }
	public string  Sku     { get; set; }
	public decimal Price   { get; set; }
	public int     Qty     { get; set; }
}