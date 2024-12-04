using Microsoft.Extensions.Caching.Memory;

namespace Ecommerce.Pedido
{
    public interface ClienteHelperAbstract
    {
        Cliente? GetClienteById(int id);
    }

    public class ClienteHelper
    {
        private const string _clienteController = "/api/cliente";
        private IMemoryCache _memoryCache;

        public ClienteHelper()
        {
            _memoryCache = GeradorDeServicos.CarregarServicoDeCache();
        }

        public Cliente? GetClienteById(int id)
        {
            var httpClient = new HttpClient();
            var url = this.GetClienteURL();

            url += _clienteController + '/' + id;

            var result = httpClient.GetAsync(url).Result;

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Cliente com ID '" + id + "' não encontrado!");
            }

            if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return null;
            }

            var cliente = result.Content.ReadFromJsonAsync<Cliente>().Result;
            if (cliente == null)
            {
                return null;
            }

            this.InsertClienteInCache(cliente);
            return cliente;
        }

        private void InsertClienteInCache(Cliente cliente)
        {
            _memoryCache.Set("Cliente" + cliente.Id, cliente, TimeSpan.FromHours(1));
        }

        private string GetClienteURL()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var url = configuration["UrlCliente"];
            return url;
        }
    }
}
