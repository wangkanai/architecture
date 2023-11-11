// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Stock : AuditableEntity<int>
{
	public Product Product       { get; set; }
	public string  Sku           { get; set; }
	public Unit    Unit          { get; set; }
	public int     Quantity      { get; set; }
	public decimal PricePurchase { get; set; }
	public decimal PriceSale     { get; set; }
}