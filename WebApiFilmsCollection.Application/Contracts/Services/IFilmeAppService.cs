using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Application.ViewModels;

namespace WebApiFilmsCollection.Application.Contracts.Services
{
    public interface IFilmeAppService
    {
        IEnumerable<FilmeViewModel> GetFilmes();
    }
}
