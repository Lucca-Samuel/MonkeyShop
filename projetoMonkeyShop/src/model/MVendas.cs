using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.model
{
    internal class MVendas
    {
        //tbl Vendas
        private int idVenda;
        private DateTime data_venda;
        private long nf_venda;
        private double valorTotal_venda;
        private int fk_id_forma_pgto;
        private int fk_id_cliente;
        private int fk_id_user;

        public int GetIdVenda()
        {
            return idVenda;
        }

        public void SetIdVenda(int value)
        {
            idVenda = value;
        }

        // Getter e Setter para data_venda
        public DateTime GetDataVenda()
        {
            return data_venda;
        }

        public void SetDataVenda(DateTime value)
        {
            data_venda = value;
        }

        // Getter e Setter para nf_venda
        public long GetNfVenda()
        {
            return nf_venda;
        }

        public void SetNfVenda(long value)
        {
            nf_venda = value;
        }

        // Getter e Setter para valorTotal_venda
        public double GetValorTotalVenda()
        {
            return valorTotal_venda;
        }

        public void SetValorTotalVenda(double value)
        {
            valorTotal_venda = value;
        }

        // Getter e Setter para fk_id_forma_pgto
        public int GetFkIdFormaPgto()
        {
            return fk_id_forma_pgto;
        }

        public void SetFkIdFormaPgto(int value)
        {
            fk_id_forma_pgto = value;
        }

        // Getter e Setter para fk_id_cliente
        public int GetFkIdCliente()
        {
            return fk_id_cliente;
        }

        public void SetFkIdCliente(int value)
        {
            fk_id_cliente = value;
        }

        // Getter e Setter para fk_id_user
        public int GetFkIdUser()
        {
            return fk_id_user;
        }

        public void SetFkIdUser(int value)
        {
            fk_id_user = value;
        }
    }
}
