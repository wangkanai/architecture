// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Wangkanai.Architecture.Identity;
using Wangkanai.Architecture.Models;

namespace Wangkanai.Architecture.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	: IdentityDbContext<ApplicationUser, ApplicationRole, string>(options)
{
	public DbSet<Pipeline> Pipelines { get; set; }
	public DbSet<Product>  Products  { get; set; }
	public DbSet<Brand>    Brands    { get; set; }
}