using System.Text.Json;
using WebAPICovid.Model;

namespace WebAPICovid.Repository
{
    public class PaisRepository : IPaisRepository
    {
        private const string APIURL = "https://api.covid19api.com/summary";

        private readonly HttpClient _httpClient;

        public PaisRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IQueryable<Pais>> BuscarTodosPaises()
        {
            var paises = new List<Pais>().AsQueryable();

            try
            {
                var response = await _httpClient.GetAsync(APIURL);
            }
            catch (Exception)
            {

                throw;
            }

            return paises;
        }
    }
}
