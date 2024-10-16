using projetoMonkeyShop.src.dao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.controller
{
    internal class CClientes
    {
        DaoClientes daoClientes = new DaoClientes();

        public int SalvarCliente(MClientes cliente)
        {
            return this.daoClientes.CadastrarCliente(cliente);
        }

        public bool ExcluirCliente(int cId)
        {
            return this.daoClientes.ExcluirCliente(cId);
        }

        public bool AlterarCliente(MClientes cliente)
        {
            return this.daoClientes.AlterarCliente(cliente);
        }

        public MClientes RetornarCliente(int cId)
        {
            return this.daoClientes.RetornarCliente(cId);
        }
    }
}
