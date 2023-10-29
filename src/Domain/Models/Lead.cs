// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Lead : AuditableEntity<int>
{
	public string   Title        { get; set; }
	public decimal  Value        { get; set; }
	public DateOnly ExpendedDate { get; set; }
}

public class LeadTag : AuditableEntity<int>
{
	public string Title { get; set; }
	public string Color { get; set; }
}