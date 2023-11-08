// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Wangkanai.Architecture.Models;

namespace Wangkanai.Architecture.Infrastructure.Persistence.Configurations;

public class StockConfiguration : IEntityTypeConfiguration<Stock>
{
	public void Configure(EntityTypeBuilder<Stock> builder)
	{
		builder.Property(stock => stock.PricePurchase)
		       .HasPrecision(9, 2);

		builder.Property(stock => stock.PriceSale)
		       .HasPrecision(9, 2);
	}
}