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
                    + "data_venda, "
                    + "valor_total, "
                    + "fk_id_forma_pgto, "
                    + "fk_id_cliente "
                    //+ "fk_id_user "
                    + ") VALUES("
                    + "'" + venda.GetDataVenda() + "',"
                    + "'" + venda.GetValorTotalVenda() + "',"
                    + "'" + venda.GetFkIdFormaPgto() + "',"
                    + "'" + venda.GetFkIdCliente() + "'"
                    //+ "'" + venda.GetFkIdUser() + "'"
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
