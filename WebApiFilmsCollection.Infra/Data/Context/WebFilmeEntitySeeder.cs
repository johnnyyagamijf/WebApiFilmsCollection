using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiFilmsCollection.Core.Entities;

namespace WebApiFilmsCollection.Infra.Data.Context
{
    public class WebFilmeEntitySeeder
    {
        public static void Seed(FilmeDataModel context)
        {
            context.Database.EnsureCreated();

            if (!context.Filmes.Any())
            {
                var filmes = new List<FilmeEntity>
                {
                    new FilmeEntity { Nome = "Rambo"},
                    new FilmeEntity { Nome = "Homem Aranha"},
                    new FilmeEntity { Nome = "Vingadores"}
                };

                context.Filmes.AddRange(filmes);
                context.SaveChanges();
            }
        }
    }
}
