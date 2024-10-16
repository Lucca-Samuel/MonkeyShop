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
    internal class DaoClientes : Conexao
    {

        public int CadastrarCliente(MClientes cliente)
        {
            try
            {
                this.Conectar();
                return this.ExecutarInsert(
                    "INSERT INTO clientes(" // Altere para o nome correto da tabela
                    + "nome, "
                    + "sobrenome, "
                    + "telefone, "
                    + "whatsapp, "
                    + "email, "
                    + "cpf, "
                    + "data_nascimento, "
                    + "rg, "
                    + "tipo_cliente, "
                    + "cep, "
                    + "logradouro, "
                    + "numero, "
                    + "complemento, "
                    + "bairro, "
                    + "cidade, "
                    + "estado, "
                    + "pais "
                    + ") VALUES ("
                    + "'" + cliente.GetName() + "',"
                    + "'" + cliente.GetSobrenome() + "',"
                    + "'" + cliente.GetTelefone() + "',"
                    + "'" + cliente.GetCelular() + "',"
                    + "'" + cliente.GetEmail() + "',"
                    + "'" + cliente.GetCpf() + "',"
                    + "'" + cliente.GetDataNascimento().ToString("yyyy-MM-dd") + "'," // Formatação para SQL
                    + "'" + cliente.GetRg() + "',"
                    + "'" + cliente.GetTipoClie() + "',"
                    + "'" + cliente.GetCep() + "',"
                    + "'" + cliente.GetLogradouro() + "',"
                    + "'" + cliente.GetNumeroLog() + "',"
                    + "'" + cliente.GetComplemento() + "',"
                    + "'" + cliente.GetBairro() + "',"
                    + "'" + cliente.GetCidade() + "',"
                    + "'" + cliente.GetUf() + "',"
                    + "'" + cliente.GetPais() + "'"
                    + ");"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar cliente: " + ex.Message);
                return 0;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        public bool ExcluirCliente(int idCliente)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                    "DELETE FROM clientes WHERE id_cliente = '" + idCliente + "'"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir cliente: " + ex.Message);
                return false;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        public bool AlterarCliente(MClientes cliente)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                    "UPDATE clientes SET "
                        + "nome = '" + cliente.GetName() + "', "
                        + "sobrenome = '" + cliente.GetSobrenome() + "', "
                        + "telefone = '" + cliente.GetTelefone() + "', "
                        + "whatsapp = '" + cliente.GetCelular() + "', "
                        + "email = '" + cliente.GetEmail() + "', "
                        + "cpf = '" + cliente.GetCpf() + "', "
                        + "data_nascimento = '" + cliente.GetDataNascimento().ToString("yyyy-MM-dd") + "', "
                        + "rg = '" + cliente.GetRg() + "', "
                        + "tipo_cliente = '" + cliente.GetTipoClie() + "', "
                        + "cep = '" + cliente.GetCep() + "', "
                        + "logradouro = '" + cliente.GetLogradouro() + "', "
                        + "numero = '" + cliente.GetNumeroLog() + "', "
                        + "complemento = '" + cliente.GetComplemento() + "', "
                        + "bairro = '" + cliente.GetBairro() + "', "
                        + "cidade = '" + cliente.GetCidade() + "', "
                        + "estado = '" + cliente.GetUf() + "', "
                        + "pais = '" + cliente.GetPais() + "' "
                        + "WHERE id_cliente = '" + cliente.GetIdCliente() + "'"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                MessageBox.Show(cliente.GetName());
                this.FecharConexao("");
            }
        }

        public MClientes RetornarCliente(int idCliente)
        {
            MClientes cliente = new MClientes();

            try
            {
                this.Conectar();
                this.ExecultarConsulta(
                    "SELECT "
                    + "id_cliente, "
                    + "nome, "
                    + "sobrenome, "
                    + "telefone, "
                    + "whatsapp, "
                    + "email, "
                    + "cpf, "
                    + "data_nascimento, "
                    + "rg, "
                    + "tipo_cliente, "
                    + "cep, "
                    + "logradouro, "
                    + "numero, "
                    + "complemento, "
                    + "bairro, "
                    + "cidade, "
                    + "estado, "
                    + "pais "
                    + "FROM clientes WHERE id_cliente = '" + idCliente + "';"
                );

                while (this.GetResultSet().NextResult())
                {
                    cliente.SetIdCliente(this.GetResultSet().GetInt32(0));
                    cliente.SetName(this.GetResultSet().GetString(1));
                    cliente.SetSobrenome(this.GetResultSet().GetString(2));
                    cliente.SetTelefone(this.GetResultSet().GetString(3));
                    cliente.SetCelular(this.GetResultSet().GetString(4)); // WhatsApp, se aplicável
                    cliente.SetEmail(this.GetResultSet().GetString(5));
                    cliente.SetCpf(this.GetResultSet().GetString(6));
                    cliente.SetDataNascimento(this.GetResultSet().GetDateTime(7));
                    cliente.SetRg(this.GetResultSet().GetString(8));
                    cliente.SetTipoClie(this.GetResultSet().GetString(9));
                    cliente.SetCep(this.GetResultSet().GetString(10));
                    cliente.SetLogradouro(this.GetResultSet().GetString(11));
                    cliente.SetNumeroLog(this.GetResultSet().GetInt32(12));
                    cliente.SetComplemento(this.GetResultSet().GetString(13));
                    cliente.SetBairro(this.GetResultSet().GetString(14));
                    cliente.SetCidade(this.GetResultSet().GetString(15));
                    cliente.SetUf(this.GetResultSet().GetString(16));
                    cliente.SetPais(this.GetResultSet().GetString(17));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar cliente: " + ex.Message);
            }
            finally
            {
                this.FecharConexao("");
            }

            return cliente;
        }
    }
}
