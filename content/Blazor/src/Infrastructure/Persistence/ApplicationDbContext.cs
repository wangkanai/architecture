// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using System.Reflection;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Wangkanai.Architecture.Identity;
using Wangkanai.Architecture.Models;

namespace Wangkanai.Architecture.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	: IdentityDbContext<
		ApplicationUser,
		ApplicationRole,
		string,
		ApplicationUserClaim,
		ApplicationUserRole,
		ApplicationUserLogin,
		ApplicationRoleClaim,
		ApplicationUserToken>(options)
{
	public DbSet<Lead>         Leads         { get; set; }
	public DbSet<Deal>         Deals         { get; set; }
	public DbSet<Category>     Categories    { get; set; }
	public DbSet<Product>      Products      { get; set; }
	public DbSet<Stock>        Stocks        { get; set; }
	public DbSet<Brand>        Brands        { get; set; }
	public DbSet<Country>      Countries     { get; set; }
	public DbSet<Organization> Organizations { get; set; }
	public DbSet<Contact>      Contacts      { get; set; }
	public DbSet<Unit>         Units         { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		base.OnModelCreating(builder);
	}

	protected override void OnConfiguring(DbContextOptionsBuilder builder)
	{
		base.OnConfiguring(builder);
	}
}