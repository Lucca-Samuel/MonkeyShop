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
                    + "'" + fornecedor.getNumeroLogradouroFornecedor() + ","
                    + "'" + fornecedor.getComplementoLogradouroFornecedor() + "',"
                    + "'" + fornecedor.getBairroFornecedor() + "',"
                    + "'" + fornecedor.getCidadeFornecedor() + "',"
                    + "'" + fornecedor.getUfFornecedor() + "',"
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




    }
}
