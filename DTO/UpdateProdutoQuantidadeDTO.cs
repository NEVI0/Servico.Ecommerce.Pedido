namespace Ecommerce.Pedido
{
    public class UpdateProdutoQuantidadeDTO
    {
        public int pedidoId { get; set; }
        public int produtoId { get; set; }
        public int produtoQuantidade { get; set; }
    }
}
