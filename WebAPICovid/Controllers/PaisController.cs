using Microsoft.AspNetCore.Mvc;
using WebAPICovid.Model;
using WebAPICovid.Services;

namespace WebAPICovid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaisController : ControllerBase
    {
        private readonly IPaisService _paisService;

        public PaisController(IPaisService paisService)
        {
            _paisService = paisService;
        }

        [HttpGet]
        public async Task<IQueryable<Pais>> BuscarTodosPaises()
        {
            var paises = await _paisService.BuscarTodosOsPaises();

            return (IQueryable<Pais>)Ok(paises);
        }
    }
}