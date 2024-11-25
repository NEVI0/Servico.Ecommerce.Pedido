namespace Ecommerce.Pedido
{
    public interface ServPedidoAbstract
    {
        Pedido GetPedidoById(int id);
        Pedido CreatePedido(PedidoDTO dto);
    }

    public class ServPedido : ServPedidoAbstract
    {
        private DataContext _dataContext;

        public ServPedido()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }

        public Pedido GetPedidoById(int id)
        {
            var pedido = _dataContext.Pedido.FirstOrDefault(pedido => pedido.Id == id);

            if (pedido == null)
            {
                throw new Exception("Pedido não encontrado!");
            }

            return pedido;
        }

        public Pedido CreatePedido(PedidoDTO dto)
        {
            var pedido = new Pedido();

            pedido.Id = dto.id;

            _dataContext.Add(pedido);
            _dataContext.SaveChanges();

            return pedido;
        }
    }
}
