using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SantosExpress.Domain;

namespace Domain.UnitTestProject
{
    [TestClass]
    public class ClienteUnitTest
    {
        [TestMethod]
        public void ClienteTeste()
        {
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

            Console.WriteLine(cli.Id);
            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.CPF);
            Console.WriteLine(cli.Email);
            Console.WriteLine(cli.Empresa);
            Console.WriteLine(cli.Endereco);
            Console.WriteLine(cli.Numero);
            Console.WriteLine(cli.Complemento);
            Console.WriteLine(cli.Bairro);
            Console.WriteLine(cli.Cidade);
            Console.WriteLine(cli.Estado);

            Assert.AreEqual("São Paulo", cli.Cidade, "A cidade não está sendo preenchida automaticamente");


        }
    }
}
