using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantosExpress.Domain;

namespace SantosExpress.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public List<Produto> ObterList()
        {
            return DbHelper.Query<Produto>("ProdutoObterList", null);
        }
    }
}
