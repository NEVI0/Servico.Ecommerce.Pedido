namespace Ecommerce.Pedido
{
    public interface ServPedidoAbstract
    {
        PedidoEstruturado GetPedidoById(int id);
        Pedido CreatePedido(PedidoDTO dto);
        void UpdatePedidoProduto(UpdateProdutoQuantidadeDTO dto);
    }

    public class ServPedido : ServPedidoAbstract
    {
        private DataContext _dataContext;
        private ProdutoHelper _produtoHelper;
        private ClienteHelper _clienteHelper;

        public ServPedido()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
            _produtoHelper = new ProdutoHelper();
            _clienteHelper = new ClienteHelper();
        }

        public PedidoEstruturado GetPedidoById(int id)
        {
            var pedido = _dataContext.Pedido.FirstOrDefault(pedido => pedido.Id == id);

            if (pedido == null)
            {
                throw new Exception("Pedido não encontrado!");
            }

            float total = 0;
            List<Produto> produtos = new List<Produto>();

            foreach (var produtoId in pedido.Produtos)
            {
                var produtoAchado = _produtoHelper.GetProdutoById(produtoId);

                if (produtoAchado != null)
                {
                    total += produtoAchado.Valor * produtoAchado.Quantidade;
                    produtos.Add(produtoAchado);
                }
            }

            Cliente? cliente = _clienteHelper.GetClienteById(pedido.ClienteId);
            if (cliente == null)
            {
                throw new Exception("Cliente não encontrado!");
            }

            var pedidoEstruturado = new PedidoEstruturado();

            pedidoEstruturado.Id = pedido.Id;
            pedidoEstruturado.Cliente = cliente;
            pedidoEstruturado.Produtos = produtos;
            pedidoEstruturado.Total = total;
            pedidoEstruturado.Data = pedido.Data;
            pedidoEstruturado.MetodoPagamento = pedido.MetodoPagamento;

            return pedidoEstruturado;
        }

        public Pedido CreatePedido(PedidoDTO dto)
        {
            var pedido = new Pedido();

            pedido.Id = dto.id;
            pedido.ClienteId = dto.clienteId;
            pedido.Produtos = dto.produtos;
            pedido.Data = dto.data;
            pedido.MetodoPagamento = dto.metodoPagamento;

            _dataContext.Add(pedido);
            _dataContext.SaveChanges();

            return pedido;
        }
    
        public void UpdatePedidoProduto(UpdateProdutoQuantidadeDTO dto)
        {
            var pedido = _dataContext.Pedido.FirstOrDefault(pedido => pedido.Id == dto.pedidoId);

            if (pedido == null)
            {
                throw new Exception("Pedido não encontrado!");
            }

            var produto = _produtoHelper.GetProdutoById(dto.produtoId);

            if (produto == null)
            {
                throw new Exception("Produto não encontrado!");
            }

            _produtoHelper.UpdateProdutoQuantidade(dto.produtoId, dto.produtoQuantidade);
        }
    }
}
