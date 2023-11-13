// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using System.Reflection;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Wangkanai.Architecture.Identity;
using Wangkanai.Architecture.Models;

namespace Wangkanai.Architecture.Persistence;

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
	public DbSet<Country> Countries { get; set; }

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