using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Core.Entities;

namespace WebApiFilmsCollection.Core.Contracts.Repositories
{
    public interface IFilmeRepository : IRepository<FilmeEntity>
    {
        FilmeEntity GetById(int id);
    }
}
