using System.Net.Http;
using System.Threading.Tasks;

namespace FunctionApp.Utils
{
    public class AuthConnection
    {
        private readonly HttpClient _httpClient;

        public AuthConnection(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Connection()
        {
            var connString = _httpClient.GetAsync("https://res-identityserver-dev.azurewebsites.net");
        }
    }
}
