﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantosExpress.Domain
{
    public interface IClienteRepository
    {
        Cliente ObterPorCpf(string cpf);
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        Cliente ObterPorId(string id);

    }
}
