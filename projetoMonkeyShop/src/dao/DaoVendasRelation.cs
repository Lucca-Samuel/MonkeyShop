using projetoMonkeyShop.src.conexao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.dao
{
    internal class DaoVendasRelation : Conexao
    {
        public int CadastrarVendaRl(MVendaRelation vendarl)
        {
            try
            {
                this.Conectar();
                return ExecutarInsert(
                    "INSERT INTO rl_produtos_vendas("
                    + "fk_id_produto, "
                    + "fk_id_venda, "
                    + "data_venda, "
                    + "desconto, "
                    + "qtde_vendida "
                    + ") VALUES("
                    + "'" + vendarl.GetFkIdProduto() + "',"
                    + "'" + vendarl.GetFkIdVenda() + "',"
                    + "'" + vendarl.GetData() + "',"
                    + "'" + vendarl.GetDesconto() + "',"
                    + "'" + vendarl.GetQtdeProdutos() + "'"
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
