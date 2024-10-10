using System;
using projetoMonkeyShop.src.model;
using projetoMonkeyShop.src.dao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.controller
{
    internal class CFornecedores
    {
        private DaoFornecedores daoFornecedores = new DaoFornecedores();

        /**
        * Salva um produto
        * @param produto
        * @return int
        */
        public int salvarProdutoC(MFornecedores fornecedor)
        {
            return this.daoFornecedores.CadastrarFornecedor(fornecedor);
        }

        public bool ExcluirFornecedor(int fId)
        {
            return this.daoFornecedores.ExcluirFornecedor(fId);
        }
        
        public bool AlterarFornecedor(MFornecedores fornecedores)
        {
            return this.daoFornecedores.AlterarFornecedor(fornecedores);
        }

        public MFornecedores retornarFornecedor(int fId)
        {
            return this.daoFornecedores.RetornarFornecedor(fId);
        }

    }
}
