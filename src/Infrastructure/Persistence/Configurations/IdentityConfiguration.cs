// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Architecture.Identity;

namespace Wangkanai.Architecture.Infrastructure.Persistence.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
	public void Configure(EntityTypeBuilder<ApplicationUser> builder)
	{
		builder.HasMany(user => user.Logins)
		       .WithOne()
		       .HasForeignKey(login => login.UserId)
		       .IsRequired();
	}
}