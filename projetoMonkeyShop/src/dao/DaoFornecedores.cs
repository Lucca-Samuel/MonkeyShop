using System;
using projetoMonkeyShop.src.conexao;
using projetoMonkeyShop.src.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.dao
{
    internal class DaoFornecedores : Conexao
    {

        /**
         * Cadastra um fornecedor no banco de dados
         * @param fornecedor
         * @return int (retorna o ID do fornecedor cadastrado)
         */
        public int CadastrarFornecedor(MFornecedores fornecedor)
        {
            try
            {
                this.Conectar();
                return this.ExecutarInsert(
                    "INSERT INTO fornecedores(" // Altere para o nome correto da tabela
                    + "nome_for, "
                    + "cnpj, "
                    + "pric_prod_for, "
                    + "telefone, "
                    + "whatsapp, "
                    + "email_for, "
                    + "nome_contato, "
                    + "cep, "
                    + "logradouro, "
                    + "numero, "
                    + "complemento, "
                    + "bairro, "
                    + "cidade, "
                    + "estado, "
                    + "important_infos "
                    + ") VALUES ("
                    + "'" + fornecedor.getNomeFantasiaFornecedor() + "',"
                    + "'" + fornecedor.getCnpjFornecedor() + "',"
                    + "'" + fornecedor.getProdutoFornecedor() + "',"
                    + "'" + fornecedor.getTelefoneFornecedor() + "',"
                    + "'" + fornecedor.getCelularFornecedor() + "'," // Caso tenha um método para WhatsApp, utilize-o
                    + "'" + fornecedor.getEmailFornecedor() + "'," // Supondo que você tenha um método para obter o email
                    + "'" + fornecedor.getNomeContatoFornecedor() + "',"
                    + "'" + fornecedor.getCepFornecedor() + "',"
                    + "'" + fornecedor.getLogradouroFornecedor() + "',"
                    + "'" + fornecedor.getNumeroLogradouroFornecedor() + "',"
                    + "'" + fornecedor.getComplementoLogradouroFornecedor() + "',"
                    + "'" + fornecedor.getBairroFornecedor() + "',"
                    + "'" + fornecedor.getCidadeFornecedor() + "',"
                    + "'" + fornecedor.getUfFornecedor() + "', "
                    + "'" + fornecedor.getInfoImportantFornecedor() + "'"
                    + ");"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar fornecedor: " + ex.Message);
                return 0;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        public bool ExcluirFornecedor(int idFornecedor)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                        "DELETE FROM fornecedores WHERE id_fornecedor = '" + idFornecedor + "'"
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir fornecedor: " + ex.Message);
                return false;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        public bool AlterarFornecedor(MFornecedores fornecedor)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                     "UPDATE fornecedores SET "
                        + "nome_for = '" + fornecedor.getNomeFantasiaFornecedor() + "', "
                        + "cnpj = '" + fornecedor.getCnpjFornecedor() + "', "
                        + "pric_prod_for = '" + fornecedor.getProdutoFornecedor() + "', "
                        + "telefone = '" + fornecedor.getTelefoneFornecedor() + "', "
                        + "whatsapp = '" + fornecedor.getCelularFornecedor() + "', "
                        + "email_for = '" + fornecedor.getEmailFornecedor() + "', "
                        + "nome_contato = '" + fornecedor.getNomeContatoFornecedor() + "', "
                        + "cep = '" + fornecedor.getCepFornecedor() + "', "
                        + "logradouro = '" + fornecedor.getLogradouroFornecedor() + "', "
                        + "numero = '" + fornecedor.getNumeroLogradouroFornecedor() + "', "
                        + "complemento = '" + fornecedor.getComplementoLogradouroFornecedor() + "', "
                        + "bairro = '" + fornecedor.getBairroFornecedor() + "', "
                        + "cidade = '" + fornecedor.getCidadeFornecedor() + "', "
                        + "estado = '" + fornecedor.getUfFornecedor() + "', "
                        + "important_infos = '" + fornecedor.getInfoImportantFornecedor() + "' "
                        + "WHERE id_fornecedor = '" + fornecedor.getIdFornecedor() + "'"
                    );

            }
            catch (Exception ex)
            { 
                return false;
            }
            finally
            {
                MessageBox.Show(fornecedor.getNomeFantasiaFornecedor());
                this.FecharConexao("");
            }
        }

        public MFornecedores RetornarFornecedor(int idFornecedor)
        {
            MFornecedores fornecedor = new MFornecedores();

            try
            {
                this.Conectar();
                this.ExecultarConsulta(
                        "SELECT "
                        + "id_fornecedor, "
                        + "nome_for, "
                        + "cnpj, "
                        + "pric_prod_for, "
                        + "whatsapp, "
                        + "email_for, "
                        + "nome_contato, "
                        + "cep, "
                        + "logradouro, "
                        + "numero, "
                        + "complemento, "
                        + "bairro, "
                        + "cidade, "
                        + "estado, "
                        + "important_infos "
                        + "FROM fornecedores WHERE pro_id = '" + idFornecedor + "';"
                    );
                while (this.GetResultSet().NextResult())
                {
                    fornecedor.setIdFornecedor(this.GetResultSet().GetInt32(0));
                    fornecedor.setNomeFantasiaFornecedor(this.GetResultSet().GetString(1));
                    fornecedor.setCnpjFornecedor(this.GetResultSet().GetString(2));
                    fornecedor.setProdutoFornecedor(this.GetResultSet().GetString(3));
                    fornecedor.setTelefoneFornecedor(this.GetResultSet().GetString(4));
                    fornecedor.setCelularFornecedor(this.GetResultSet().GetString(5)); // WhatsApp, se aplicável
                    fornecedor.setEmailFornecedor(this.GetResultSet().GetString(6));
                    fornecedor.setNomeContatoFornecedor(this.GetResultSet().GetString(7));
                    fornecedor.setCepFornecedor(this.GetResultSet().GetString(8));
                    fornecedor.setLogradouroFornecedor(this.GetResultSet().GetString(9));
                    fornecedor.setNumeroLogradouroFornecedor(this.GetResultSet().GetInt32(10));
                    fornecedor.setComplementoLogradouroFornecedor(this.GetResultSet().GetString(11));
                    fornecedor.setBairroFornecedor(this.GetResultSet().GetString(12));
                    fornecedor.setCidadeFornecedor(this.GetResultSet().GetString(13));
                    fornecedor.setUfFornecedor(this.GetResultSet().GetString(14));
                    fornecedor.setInfoImportantFornecedor(this.GetResultSet().GetString(15));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar fornecedor: " + ex.Message);
            }
            finally
            {
                this.FecharConexao("");
            }

            return fornecedor;
        }


    }
}
