using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;

namespace Ecommerce.Pedido
{
    public interface ProdutoHelperAbstract
    {
        Produto? GetProdutoById(int id);
        Produto? UpdateProdutoQuantidade(int id, int quantidade);
    }

    public class ProdutoHelper
    {
        private const string _produtoController = "/api/produto";
        private IMemoryCache _memoryCache;

        public ProdutoHelper()
        {
            _memoryCache = GeradorDeServicos.CarregarServicoDeCache();
        }

        public Produto? GetProdutoById(int id)
        {
            var httpClient = new HttpClient();
            var url = this.GetProdutoURL();

            url += _produtoController + '/' + id;

            var result = httpClient.GetAsync(url).Result;

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Produto com ID '" + id + "' não encontrado!");
            }

            if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return null;
            }

            var produto = result.Content.ReadFromJsonAsync<Produto>().Result;
            if (produto == null)
            {
                return null;
            }

            this.InsertProdutoInCache(produto);
            return produto;
        }

        public Produto? UpdateProdutoQuantidade(int id, int quantidade)
        {
            var httpClient = new HttpClient();
            var url = this.GetProdutoURL();

            url += _produtoController + "/quantidade";

            var data = new
            {
                id = id,
                quantidade = quantidade
            };

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var result = httpClient.PutAsync(url, content).Result;

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Produto com ID '" + id + "' não encontrado!");
            }

            if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return null;
            }

            var produto = result.Content.ReadFromJsonAsync<Produto>().Result;
            if (produto == null)
            {
                return null;
            }

            this.InsertProdutoInCache(produto);
            return produto;
        }

        private void InsertProdutoInCache(Produto produto)
        {
            _memoryCache.Set("Produto" + produto.Id, produto, TimeSpan.FromHours(1));
        }

        private string GetProdutoURL()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var url = configuration["UrlProduto"];
            return url;
        }
    }
}
