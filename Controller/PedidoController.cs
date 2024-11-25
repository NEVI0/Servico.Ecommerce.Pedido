using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Pedido
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private ServPedidoAbstract _servPedido;

        public PedidoController()
        {
            _servPedido = new ServPedido();
        }

        [Route("/api/pedido/{id}")]
        [HttpGet]
        public IActionResult GetPedidoById(int id)
        {
            try
            {
                var pedido = _servPedido.GetPedidoById(id);
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("/api/pedido")]
        [HttpPost]
        public IActionResult PostPedido(PedidoDTO dto)
        {
            try
            {
                var pedido = _servPedido.CreatePedido(dto);
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
