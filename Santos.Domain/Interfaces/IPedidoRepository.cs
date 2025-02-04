﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantosExpress.Domain
{
    public interface IPedidoRepository
    {
        void Incluir(Pedido pedido);
        List<Pedido> ObterPedidosSolicitados();
        List<Pedido> ObterPedidosEmProducao();
        List<Pedido> ObterPedidosProduzidos();
        List<Pedido> ObterPedidosEmTransporte();
        List<Pedido> ObterPedidosEntregues();
        List<Pedido> ObterPedidos();

        void AlterarStatusPedido(string PedidoId, PedidoStatus status);


    }
}
