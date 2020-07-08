using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiFilmsCollection.Core.Contracts.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}
