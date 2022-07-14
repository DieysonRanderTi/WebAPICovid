using WebAPICovid.Model;
using WebAPICovid.Repository;

namespace WebAPICovid.Services
{
    public class PaisService : IPaisService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisService(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public Task<IQueryable<Pais>> BuscarTodosOsPaises()
        {
            return _paisRepository.BuscarTodosPaises();
        }
    }
}
