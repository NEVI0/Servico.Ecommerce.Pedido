namespace Ecommerce.Pedido
{
    public class Produto
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public string? Imagem { get; set; }

        public float Valor { get; set; }

        public int Quantidade { get; set; }
    }
}
