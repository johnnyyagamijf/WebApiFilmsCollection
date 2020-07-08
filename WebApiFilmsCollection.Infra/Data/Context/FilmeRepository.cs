using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Core.Contracts.Repositories;
using WebApiFilmsCollection.Core.Entities;
using WebApiFilmsCollection.Infra.Data.Repositories;

namespace WebApiFilmsCollection.Infra.Data.Context
{
    public class FilmeRepository : Repository<FilmeEntity>, IFilmeRepository
    {
        public FilmeRepository(FilmeDataModel context)
            : base(context)
        {

        }

        public IEnumerable<FilmeEntity> GetAll()
        {
            return _context.Set<FilmeEntity>();
        }
        public FilmeEntity GetById(int id)
        {
            return _context.Set<FilmeEntity>().Find(id);
        }
    }
}
