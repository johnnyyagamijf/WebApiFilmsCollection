using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Core.Entities;

namespace WebApiFilmsCollection.Infra.Data.Configuration
{
    public class FilmeConfiguration : IEntityTypeConfiguration<FilmeEntity>
    {
        public void Configure(EntityTypeBuilder<FilmeEntity> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(30)");
        }
    }
}
