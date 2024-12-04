namespace Ecommerce.Pedido
{
    public class PedidoEstruturado
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public List<Produto> Produtos { get; set; }

        public float Total { get; set; }

        public DateTime? Data { get; set; }

        public string? MetodoPagamento { get; set; }
    }
}
