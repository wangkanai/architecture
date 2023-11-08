// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

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

public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
{
	public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
	{
		builder.HasOne(role => role.Role)
		       .WithMany(role => role.UserRoles)
		       .HasForeignKey(role => role.RoleId)
		       .OnDelete(DeleteBehavior.Cascade);

		builder.HasOne(role => role.User)
		       .WithMany(user => user.UserRoles)
		       .HasForeignKey(role => role.UserId)
		       .OnDelete(DeleteBehavior.Cascade);
	}
}

public class ApplicationUserClaimConfiguration : IEntityTypeConfiguration<ApplicationUserClaim>
{
	public void Configure(EntityTypeBuilder<ApplicationUserClaim> builder)
	{
		builder.HasOne(claim => claim.User)
		       .WithMany(user => user.UserClaims)
		       .HasForeignKey(claim => claim.UserId)
		       .OnDelete(DeleteBehavior.Cascade);
	}
}

public class ApplicationRoleClaimConfiguration : IEntityTypeConfiguration<ApplicationRoleClaim>
{
	public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
	{
		builder.HasOne(claim => claim.Role)
		       .WithMany(role => role.RoleClaims)
		       .HasForeignKey(claim => claim.RoleId)
		       .OnDelete(DeleteBehavior.Cascade);
	}
}

public class ApplicationUserLoginConfiguration : IEntityTypeConfiguration<ApplicationUserLogin>
{
	public void Configure(EntityTypeBuilder<ApplicationUserLogin> builder)
	{
		builder.HasOne(login => login.User)
		       .WithMany(user => user.Logins)
		       .HasForeignKey(login => login.UserId)
		       .OnDelete(DeleteBehavior.Cascade);
	}
}