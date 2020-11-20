using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantosExpress.Domain
{
    public class PedidoListViewModel
    {
        public PedidoStatus Status { get; set; }
        public List<Pedido> PedidoList { get; set; }
    }

}
