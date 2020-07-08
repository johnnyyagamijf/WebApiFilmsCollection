using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Core.Contracts.Repositories;
using WebApiFilmsCollection.Infra.Data.Context;

namespace WebApiFilmsCollection.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public readonly FilmeDataModel _context;
        public Repository(FilmeDataModel context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }
    }
}
