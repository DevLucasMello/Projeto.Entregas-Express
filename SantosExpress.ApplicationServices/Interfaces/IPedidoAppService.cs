using SantosExpress.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantosExpress.ApplicationServices
{
    public interface IPedidoAppService:IPedidoRepository
    {
        Pedido ObterNovoPedido(string clienteId);
    }
}
