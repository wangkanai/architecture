// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Architecture.Models;

namespace Wangkanai.Architecture.Infrastructure.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
	public void Configure(EntityTypeBuilder<Category> builder)
	{
		builder.Property(category => category.Name)
		       .HasMaxLength(50)
		       .IsRequired();
	}
}