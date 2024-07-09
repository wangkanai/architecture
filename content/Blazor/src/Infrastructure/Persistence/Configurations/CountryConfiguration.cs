// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Architecture.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Architecture.Persistence.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
	public void Configure(EntityTypeBuilder<Country> builder)
	{
		builder.Property(country => country.Name)
		       .HasMaxLength(50)
		       .IsRequired();
	}
}