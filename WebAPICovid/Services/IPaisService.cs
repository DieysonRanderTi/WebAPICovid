using WebAPICovid.Model;

namespace WebAPICovid.Services
{
    public interface IPaisService
    {
        Task<IQueryable<Pais>> BuscarTodosOsPaises();
    }
}
