using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantosExpress.Domain
{
    public interface IPedidoProdutoItemRepository
    {
        List<PedidoProdutoItem> ObterPedidoProdutoItem();
    }
}
