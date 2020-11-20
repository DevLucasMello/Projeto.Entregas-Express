using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SantosExpress.Domain;
using SantosExpress.Repository;


namespace Repository.UnitTestProject
{
    [TestClass]
    public class PedidoUnitTest
    {

        [TestMethod]
        public void PedidoTeste()
        {
            /*
            var produtoRep = new ProdutoRepository();
            var pedidoProdutoItemRep = new PedidoProdutoItemRepository();

            var produtoList = produtoRep.ObterProdutoList();
            var itemList = new List<PedidoProdutoItem>();
            foreach(var p in produtoList)
            {
                itemList.Add(new PedidoProdutoItem()
                {
                    Quantidade = 0,
                    Produto = new Produto()
                    {
                        Id = p.Id,
                        Nome = p.Nome,
                        Preco = p.Preco
                    }
                });
            }

            foreach(var item in itemList)
            {
                Console.WriteLine(item.Quantidade + " "
                    + item.Produto.Nome + " "
                    + item.Produto.Preco.ToString("C") + " "
                    + item.Produto.Id
                    );
            }

            Assert.AreEqual(produtoList.Count, itemList.Count, "As listas deveriam ter o mesmo tamanho");
            */

        }
    }
}
