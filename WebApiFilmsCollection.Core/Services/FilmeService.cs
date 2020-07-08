using System.Collections.Generic;
using WebApiFilmsCollection.Core.Contracts.Repositories;
using WebApiFilmsCollection.Core.Contracts.Services;
using WebApiFilmsCollection.Core.Entities;

namespace WebApiFilmsCollection.Core.Services
{
    public class FilmeService: IFilmeService
    {
        private readonly IFilmeRepository _IfilmeRepository;
        public FilmeService(IFilmeRepository filmeRepository)
        {
            _IfilmeRepository = filmeRepository;
        }

        public IEnumerable<FilmeEntity> GetAll()
        {
            return _IfilmeRepository.GetAll();
        }
    }
}
