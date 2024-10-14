using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.model
{
    internal class MVendaRelation
    {
        //tbl relacionamento vendas
        private int fk_id_produto;
        private int fk_id_venda;
        private double desconto;
        private int qtde_produtos;
        private DateTime data;

        public int GetFkIdProduto()
        {
            return fk_id_produto;
        }

        public void SetFkIdProduto(int value)
        {
            fk_id_produto = value;
        }

        // Getter e Setter para fk_id_venda
        public int GetFkIdVenda()
        {
            return fk_id_venda;
        }

        public void SetFkIdVenda(int value)
        {
            fk_id_venda = value;
        }

        // Getter e Setter para desconto
        public double GetDesconto()
        {
            return desconto;
        }

        public void SetDesconto(double value)
        {
            desconto = value;
        }

        // Getter e Setter para qtde_produtos
        public int GetQtdeProdutos()
        {
            return qtde_produtos;
        }

        public void SetQtdeProdutos(int value)
        {
            qtde_produtos = value;
        }

        // Getter e Setter para data
        public DateTime GetData()
        {
            return data;
        }

        public void SetData(DateTime value)
        {
            data = value;
        }
    }
}
