// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Architecture.Identity;

namespace Wangkanai.Architecture.Infrastructure.Persistence.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
	public void Configure(EntityTypeBuilder<ApplicationUser> builder)
	{
		builder.HasMany(user => user.UserClaims)
		       .WithOne()
		       .HasForeignKey(claim => claim.UserId)
		       .IsRequired();

		builder.HasMany(user => user.Logins)
		       .WithOne()
		       .HasForeignKey(login => login.UserId)
		       .IsRequired();

		builder.HasMany(user => user.Tokens)
		       .WithOne()
		       .HasForeignKey(token => token.UserId)
		       .IsRequired();

		builder.HasMany(user => user.UserRoles)
		       .WithOne()
		       .HasForeignKey(role => role.UserId)
		       .IsRequired();
	}
}

public class ApplicationUserTokenConfiguration : IEntityTypeConfiguration<ApplicationUserToken>
{
	public void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
	{
		builder.HasOne(token => token.User)
		       .WithMany(user => user.Tokens)
		       .HasForeignKey(token => token.UserId)
		       .OnDelete(DeleteBehavior.Cascade);
	}
}