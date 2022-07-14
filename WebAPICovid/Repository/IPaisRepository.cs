using WebAPICovid.Model;

namespace WebAPICovid.Repository
{
    public interface IPaisRepository
    {
        Task<IQueryable<Pais>> BuscarTodosPaises();
    }
}
