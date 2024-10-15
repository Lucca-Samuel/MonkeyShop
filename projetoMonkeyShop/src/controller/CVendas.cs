using projetoMonkeyShop.src.dao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.controller
{
    internal class CVendas
    {
        private DaoVendas daoVendas = new DaoVendas();

        public int salvarVenda(MVendas vendas)
        {
            return daoVendas.CadastrarVenda(vendas);
        }
    }
}
