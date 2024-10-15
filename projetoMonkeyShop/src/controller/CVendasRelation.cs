using projetoMonkeyShop.src.dao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.controller
{
    internal class CVendasRelation
    {
        private DaoVendasRelation daoVendasRelation = new DaoVendasRelation();

        public int SalvarVendaRelation(MVendaRelation vRl)
        {
            return daoVendasRelation.CadastrarVendaRl(vRl);
        }
    }
}
