namespace Ecommerce.Pedido
{
    public class Pedido
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public List<int> Produtos { get; set; }

        public DateTime? Data { get; set; }

        public string? MetodoPagamento { get; set; }
    }
}
