using projetoMonkeyShop.src.conexao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.dao
{
    internal class DaoProdutos : Conexao
    {
        /**
        * Cadastra um produto no banco de dados
        * @param produto
        * @return int (retorna o ID do produto cadastrado)
        */
        public int CadastrarProduto(MProdutos produto)
        {
            try
            {
                this.Conectar();
                return this.ExecutarInsert(
                        "INSERT INTO tbl_produtos("
                        + "pro_cod,"
                        + "pro_nome,"
                        + "pro_categoria,"
                        + "pro_modelo,"
                        + "pro_tamanho,"
                        + "pro_cor,"
                        + "pro_qtd,"
                        + "pro_status,"
                        + "pro_preco"
                        + ") VALUES ("
                        + "'" + produto.getCodProduto() + "',"
                        + "'" + produto.getNomeProduto() + "',"
                        + "'" + produto.getCategoriaProduto() + "',"
                        + "'" + produto.getModeloProduto() + "',"
                        + "'" + produto.getTamanhoProduto() + "',"
                        + "'" + produto.getCorProduto() + "',"
                        + "'" + produto.getQtdProduto() + "',"
                        + "'" + produto.getStatusProduto() + "',"
                        + "'" + produto.getPrecoProduto() + "'"
                        +");"
                    );

                 /*string sql = "INSERT INTO tbl_produtos (pro_cod, pro_nome, pro_categoria, pro_modelo, pro_tamanho, pro_cor, pro_qtd, pro_status, pro_preco) " +
                             "VALUES (@CodProduto, @NomeProduto, @CategoriaProduto, @ModeloProduto, @TamanhoProduto, @CorProduto, @QtdProduto, @StatusProduto, @PrecoProduto);";
                SqlCommand cmd = new SqlCommand(sql, GetCon());
                    //Definindo os parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@CodProduto", produto.getCodProduto());
                    cmd.Parameters.AddWithValue("@NomeProduto", produto.getNomeProduto());
                    cmd.Parameters.AddWithValue("@CategoriaProduto", produto.getCategoriaProduto());
                    cmd.Parameters.AddWithValue("@ModeloProduto", produto.getModeloProduto());
                    cmd.Parameters.AddWithValue("@TamanhoProduto", produto.getTamanhoProduto());
                    cmd.Parameters.AddWithValue("@CorProduto", produto.getCorProduto());
                    cmd.Parameters.AddWithValue("@QtdProduto", produto.getQtdProduto());
                    cmd.Parameters.AddWithValue("@StatusProduto", produto.getStatusProduto());
                    cmd.Parameters.AddWithValue("@PrecoProduto", produto.getPrecoProduto());
                    cmd.ExecuteNonQuery();
                    //Recupera o ID do último produto inserido
                    cmd.CommandText = "SELECT SCOPE_IDENTITY();";
                    return Convert.ToInt32(cmd.ExecuteScalar());*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar produto: " + ex.Message);
                return 0;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        /**
        * Exclui um produto do banco de dados
        * @param idProduto
        * @return bool
        */
        public bool ExcluirProduto(int idProduto)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                        "DELETE FROM tbl_produtos WHERE pro_id = '" + idProduto + "'"
                    );
                /*string sql = "DELETE FROM tbl_produtos WHERE pro_id = @IdProduto";
                SqlCommand cmd = new SqlCommand(sql, GetCon());
                cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                cmd.ExecuteNonQuery();
                return true;*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir produto: " + ex.Message);
                return false;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        /**
        * Atualiza um produto no banco de dados
        * @param produto
        * @return bool
        */
        public bool AlterarProduto(MProdutos produto)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                        "UPDATE tbl_produtos SET "
                        + "pro_nome = '" + produto.getNomeProduto()+"',"
                        + "pro_categoria = '" + produto.getCategoriaProduto()+"',"
                        + "pro_modelo = '" + produto.getModeloProduto()+"',"
                        + "pro_tamanho = '" + produto.getTamanhoProduto()+"',"
                        + "pro_cor = '" + produto.getCorProduto()+"',"
                        + "pro_qtd = '" + produto.getQtdProduto()+"',"
                        + "pro_status = '" + produto.getStatusProduto()+"',"
                        + "pro_preco = '" + produto.getPrecoProduto()+"'"
                        + " WHERE pro_id = '" + produto.getIdProduto()+"'"
                    );

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar produto: " + ex.Message);
                return false;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        /**
        * Retorna um produto pelo ID
        * @param idProduto
        * @return MProdutos
        */
        public MProdutos RetornarProduto(int idProduto)
        {
            MProdutos produto = new MProdutos();

            try
            {
                this.Conectar();
                this.ExecultarConsulta(
                        "SELECT "
                        + "pro_id, "
                        + "pro_cod, "
                        + "pro_nome, "
                        + "pro_categoria, "
                        + "pro_modelo, "
                        + "pro_tamanho, "
                        + "pro_cor, "
                        + "pro_qtd, "
                        + "pro_status, "
                        + "pro_preco"
                        + "FROM tbl_produtos WHERE pro_id = '" + idProduto + "';"
                    );
                while(this.GetResultSet().NextResult())
                {
                    produto.SetIdProduto(this.GetResultSet().GetInt32(0));
                    produto.SetCodProduto(this.GetResultSet().GetInt64(1));
                    produto.SetNomeProduto(this.GetResultSet().GetString(2));
                    produto.SetCategoriaProduto(this.GetResultSet().GetString(3));
                    produto.SetModeloProduto(this.GetResultSet().GetString(4));
                    produto.SetTamanhoProduto(this.GetResultSet().GetString(5));
                    produto.SetCorProduto(this.GetResultSet().GetString(6));
                    produto.SetQtdProduto(this.GetResultSet().GetInt32(7));
                    produto.SetStatusProduto(this.GetResultSet().GetString(8));
                    produto.SetPrecoProduto(this.GetResultSet().GetFloat(9));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar produto: " + ex.Message);
            }
            finally
            {
                this.FecharConexao("");
            }

            return produto;
        }

        /**
        * Retorna uma lista completa de produtos
        * @return List<MProdutos>
        */
        public List<MProdutos> RetornarListaDeProdutos()
        {
            List<MProdutos> listaProdutos = new List<MProdutos>();
            MProdutos produto = new MProdutos();

            try
            {
                this.Conectar();
               this.ExecultarConsulta(
                        "SELECT "
                        + "pro_id, "
                        + "pro_cod, "
                        + "pro_nome, "
                        + "pro_categoria, "
                        + "pro_modelo, "
                        + "pro_tamanho, "
                        + "pro_cor, "
                        + "pro_qtd, "
                        + "pro_status, "
                        + "pro_preco "
                        + "FROM tbl_produtos ;" 
               );

                while(this.GetResultSet().NextResult())
                {
                    produto.SetIdProduto(this.GetResultSet().GetInt32(0));
                    produto.SetCodProduto(this.GetResultSet().GetInt64(1));
                    produto.SetNomeProduto(this.GetResultSet().GetString(2));
                    produto.SetCategoriaProduto(this.GetResultSet().GetString(3));
                    produto.SetModeloProduto(this.GetResultSet().GetString(4));
                    produto.SetTamanhoProduto(this.GetResultSet().GetString(5));
                    produto.SetCorProduto(this.GetResultSet().GetString(6));
                    produto.SetQtdProduto(this.GetResultSet().GetInt32(7));
                    produto.SetStatusProduto(this.GetResultSet().GetString(8));
                    produto.SetPrecoProduto(this.GetResultSet().GetFloat(9));
                    listaProdutos.Add( produto );
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar lista de produtos: " + ex.Message);
            }
            finally
            {
                this.FecharConexao("");
            }

            return listaProdutos;
        }


    }
}

    

