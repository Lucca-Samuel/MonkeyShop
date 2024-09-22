using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace projetoMonkeyShop.src.model
{
    internal class MProdutos
    {
        private int id_produto;
        private int cod_produto;
        private string nome_produto;
        private string categoria_produto;
        private string modelo_produto;
        private string tamanho_produto;
        private string cor_produto;
        private int qtd_produto;
        private string status_produto;
        private double preco_produto;


        //getter's dos atributos
        public int getIdProduto()
        {
            return id_produto;
        }

        public int getCodProduto()
        {
            return cod_produto;
        }

        public string getNomeProduto() 
        { 
            return nome_produto;
        }

        public string getCategoriaProduto()
        {
            return categoria_produto;
        }

        public string getModeloProduto()
        {
            return modelo_produto;
        }

        public string getTamanhoProduto()
        {
            return tamanho_produto;
        }

        public string getCorProduto()
        {
            return cor_produto;
        }

        public int getQtdProduto()
        {
            return qtd_produto;
        }

        public string getStatusProduto()
        {
            return status_produto;
        }

        public double getPrecoProduto()
        {
            return preco_produto;
        }

        //set's dos atributos
        public void SetIdProduto(int id_produto)
        {
            this.id_produto = id_produto;
        }

        public void SetCodProduto(int cod_produto)
        {
            this.cod_produto = cod_produto;
        }

        public void SetNomeProduto(string nome_produto)
        {
            this.nome_produto = nome_produto;
        }

        public void SetCategoriaProduto(string categoria_produto)
        {
            this.categoria_produto = categoria_produto;
        }

        public void SetModeloProduto(string modelo_produto)
        {
            this.modelo_produto = modelo_produto;
        }

        public void SetTamanhoProduto(string tamanho_produto)
        {
            this.tamanho_produto = tamanho_produto;
        }

        public void SetCorProduto(string cor_produto)
        {
            this.cor_produto = cor_produto;
        }

        public void SetQtdProduto(int qtd_produto)
        {
            this.qtd_produto = qtd_produto;
        }

        public void SetStatusProduto(string status_produto)
        {
            this.status_produto = status_produto;
        }

        public void SetPrecoProduto(double preco_produto)
        {
            this.preco_produto = preco_produto;
        }

    }
}
