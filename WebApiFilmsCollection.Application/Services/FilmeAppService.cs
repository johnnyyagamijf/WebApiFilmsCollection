using System.Collections.Generic;
using WebApiFilmsCollection.Application.Contracts.Services;
using WebApiFilmsCollection.Application.ViewModels;
using WebApiFilmsCollection.Core.Contracts.Services;

namespace WebApiFilmsCollection.Application.Services
{
    using AutoMapper;
    using WebApiFilmsCollection.Core.Entities;

    public class FilmeAppService : IFilmeAppService
    {
        private IFilmeService _iFilmeService;
        private readonly IMapper _mapper;
        public FilmeAppService(IFilmeService filmeService, IMapper mapper)
        {
            _iFilmeService = filmeService;
            _mapper = mapper;
        }
        public IEnumerable<FilmeViewModel> GetFilmes()
        {
            var result = _iFilmeService.GetAll();
            return _mapper.Map<IEnumerable<FilmeEntity>, IEnumerable<FilmeViewModel>>(result);
        }
    }
}
