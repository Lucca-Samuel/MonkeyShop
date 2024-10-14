using System;
using projetoMonkeyShop.src.conexao;
using projetoMonkeyShop.src.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.dao
{
    internal class DaoVendas : Conexao
    {
        public int CadastrarVenda(MVendas venda)
        {
            try
            {
                this.Conectar();
                return ExecutarInsert(
                    "INSERT INTO vendas("
                    + "id_venda, "
                    + "data_venda, "
                    + "nota_fisca, "
                    + "valor_total, "
                    + "fk_id_forma_pgto, "
                    + "fk_id_cliente, "
                    + "fk_id_user "
                    + ") VALUES("
                    + "'" + venda.GetIdVenda() + "',"
                    + "'" + venda.GetDataVenda() + "',"
                    + "'" + venda.GetNfVenda() + "',"
                    + "'" + venda.GetValorTotalVenda() + "',"
                    + "'" + venda.GetFkIdFormaPgto() + "',"
                    + "'" + venda.GetFkIdCliente() + "',"
                    + "'" + venda.GetFkIdUser() + "'"
                    + ");"
                    );
            }catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                this.FecharConexao("");
            }
        }
    }
}
