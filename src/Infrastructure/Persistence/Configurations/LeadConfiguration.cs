// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Architecture.Models;

namespace Wangkanai.Architecture.Infrastructure.Persistence.Configurations;

public class LeadConfiguration : IEntityTypeConfiguration<Lead>
{
	public void Configure(EntityTypeBuilder<Lead> builder)
	{
		builder.Property(lead => lead.Value)
		       .HasPrecision(9, 2);
	}
}