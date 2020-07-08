using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiFilmsCollection.Application.Contracts.Services;

namespace WebApiFilmsCollection.Controllers
{
    [Route("api/[controller]")]
    public class FilmesController : Controller
    {
        private readonly IFilmeAppService _filmeAppService;
        public FilmesController(IFilmeAppService filmeAppService)
        {
            _filmeAppService = filmeAppService;
        }
        public string Ativo() => "WebAtivo";

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            var result = _filmeAppService.GetFilmes();
            return Ok(result);
        }
        
    }
}