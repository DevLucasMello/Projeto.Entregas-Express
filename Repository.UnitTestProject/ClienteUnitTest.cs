using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SantosExpress.Domain;
using SantosExpress.Repository;

namespace Repository.UnitTestProject
{
    [TestClass]
    public class ClienteUnitTest
    {
        [TestMethod]
        public void ClienteNovoTest()
        {
            var clienteRep = new ClienteRepository();
            var cli = new Cliente();
            cli.Id = Guid.NewGuid().ToString();
            cli.Nome = "Maria Exemplo da Silva";
            cli.CPF = "213.234.234-23";
            cli.Email = "maria.exemplo@teste.com.br";
            cli.Empresa = "Empresa ACME";
            cli.Endereco = "Avenida Etc e Tal";
            cli.Numero = "234";
            cli.Complemento = "Sala 23";
            cli.Bairro = "Vila Exemplo";

            clienteRep.Incluir(cli);

            var clienteGravado = clienteRep.ObterPorCpf("213.234.234-23");
            if (clienteGravado != null)
            {
                Console.WriteLine(clienteGravado.Id);
                Console.WriteLine(clienteGravado.Nome);
                Console.WriteLine(clienteGravado.CPF);
                Console.WriteLine(clienteGravado.Email);
                Console.WriteLine(clienteGravado.Empresa);
                Console.WriteLine(clienteGravado.Endereco);
                Console.WriteLine(clienteGravado.Numero);
                Console.WriteLine(clienteGravado.Complemento);
                Console.WriteLine(clienteGravado.Bairro);
                Console.WriteLine(clienteGravado.Cidade);
                Console.WriteLine(clienteGravado.Estado);
            }

            Assert.IsNotNull(clienteGravado, "Deveria ter localizado o cliente com este CPF");


        }
    }
}
