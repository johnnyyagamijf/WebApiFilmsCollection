using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Core.Contracts.Repositories;
using WebApiFilmsCollection.Core.Entities;
using WebApiFilmsCollection.Core.Services;

namespace WebApiFilmsCollection.Core.Contracts.Services
{
    public interface IFilmeService 
    {
        IEnumerable<FilmeEntity> GetAll();
    }
}
