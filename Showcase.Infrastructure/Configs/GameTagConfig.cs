﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Showcase.Domain.Entities;

namespace Showcase.Infrastructure.Configs
{
    internal class GameTagConfig : IEntityTypeConfiguration<GameTag>
    {
        public void Configure(EntityTypeBuilder<GameTag> builder)
        {
            builder.ToTable("T_Games_Tags");
            builder.Property(x => x.GameId).HasConversion<CompanyId.EfValueConverter>();
            builder.Property(x => x.TagId).HasConversion<TagId.EfValueConverter>();


        }
    }
}
