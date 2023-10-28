// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Domain;

namespace Wangkanai.Architecture.Models;

public class Contact : AuditableEntity<int>
{
	public string       Firstname    { get; set; }
	public string       Middlename   { get; set; }
	public string       Lastname     { get; set; }
	public string       JobTitle     { get; set; }
	public Contact      Manager      { get; set; }
	public Organization Organization { get; set; }
	public Gender       Gender       { get; set; }
	public DateOnly     Birthday     { get; set; }
	public DateOnly     Anniversary  { get; set; }
	public string       Email        { get; set; }
	public string       Telephone    { get; set; }
	public string       Mobile       { get; set; }
	public string       Address      { get; set; }
	public string       Province     { get; set; }
	public string       Zipcode      { get; set; }
	public Country      Country      { get; set; }
	public string       LinkedIn     { get; set; }
}

public class Organization : AuditableEntity<int>
{
	public string   Name         { get; set; }
	public string   LegalName    { get; set; }
	public string   RegisterId   { get; set; }
	public DateOnly RegisterDate { get; set; }
	public string   Address      { get; set; }
	public string   Province     { get; set; }
	public string   Zipcode      { get; set; }
	public Country  Country      { get; set; }
}