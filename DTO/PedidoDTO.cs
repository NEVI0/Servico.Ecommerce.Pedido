namespace Ecommerce.Pedido
{
    public class PedidoDTO
    {
        public int id { get; set; }

        public int clienteId { get; set; }

        public List<int> produtos { get; set; }

        public DateTime? data { get; set; }

        public string? metodoPagamento { get; set; }
    }
}
