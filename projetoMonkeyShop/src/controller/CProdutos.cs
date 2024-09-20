using System;
using projetoMonkeyShop.src.model;
using projetoMonkeyShop.src.dao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.controller
{
    internal class CProdutos
    {
        private DaoProdutos daoProdutos = new DaoProdutos();

        /**
         * Salva um produto
         * @param produto
         * @return int
         */
        public int salvarProdutoC(MProdutos produto)
        {
            return this.daoProdutos.CadastrarProduto(produto);
        }

        /**
         * Exclui um produto
         * @param pCodigo
         * @return boolean
         */
        public bool excluirProdutoC(int pId)
        {
            return this.daoProdutos.ExcluirProduto(pId);
        }

        /**
         * Altera um produto
         * @param mProduto
         * @return boolean
         */
        public bool alterarProdutoC(MProdutos mProduto)
        {
            return this.daoProdutos.AlterarProduto(mProduto);
        }

        /**
         * retorna produto pelo código 
         * @param pCodigo
         * @return Produtos
         */
        public MProdutos retornarProdutoC(int pCodigo)
        {
            return this.daoProdutos.RetornarProduto(pCodigo);
        }

        /**
         * Retorna uma lista de produtos
         * @return ArrayList
         */
        public List<MProdutos> retornarListaProdutoC()
        {
            return this.daoProdutos.RetornarListaDeProdutos();
        }
    }
}
