// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Wangkanai.Architecture.Identity;

namespace Wangkanai.Architecture.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	: IdentityDbContext<ApplicationUser, ApplicationRole, string>(options)
{
}