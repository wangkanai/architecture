// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Deal : AuditableEntity<int>
{
	public string        Title        { get; set; }
	public string?       Description  { get; set; }
	public Stage         Stage        { get; set; }
	public decimal       Value        { get; set; }
	public Currency      Currency     { get; set; }
	public Organization? Organization { get; set; }
	public Contact?      Contact      { get; set; }
}