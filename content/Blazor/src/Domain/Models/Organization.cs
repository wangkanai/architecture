// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Organization : AuditableEntity<int>
{
	public Organization?      Parent       { get; set; }
	public string?            Name         { get; set; }
	public string?            LegalName    { get; set; }
	public string?            RegisterId   { get; set; }
	public DateOnly?          RegisterDate { get; set; }
	public string?            Address      { get; set; }
	public string?            Province     { get; set; }
	public string?            Zipcode      { get; set; }
	public Country?           Country      { get; set; }
	public string?            Email        { get; set; }
	public string?            Telephone    { get; set; }
	public string?            Mobile       { get; set; }
	public string?            Website      { get; set; }
	public List<Organization> Subsidiaries { get; set; }
	public List<Contact>      Employees    { get; set; }
}