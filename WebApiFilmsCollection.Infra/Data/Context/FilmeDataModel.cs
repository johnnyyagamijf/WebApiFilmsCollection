using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;
using WebApiFilmsCollection.Core.Entities;
using WebApiFilmsCollection.Infra.Data.Configuration;

namespace WebApiFilmsCollection.Infra.Data.Context
{
    public class FilmeDataModel : DbContext
    {
        public FilmeDataModel(DbContextOptions<FilmeDataModel> options) 
            : base(options)
        {
        }
        public DbSet<FilmeEntity> Filmes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
        }
    }
}
