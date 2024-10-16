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
    internal class DaoUsers : Conexao
    {
        public int CadastrarUsuario(MUsers usuario)
        {
            try
            {
                this.Conectar();
                return this.ExecutarInsert(
                    "INSERT INTO usuarios(" // Nome da tabela corrigido
                    + "nome, "
                    + "email, "
                    + "login_user, "
                    + "senha_user "
                    + ") VALUES ("
                    + "'" + usuario.getNameUser() + "',"
                    + "'" + usuario.getEmailUser() + "',"
                    + "'" + usuario.getLoginUser() + "',"
                    + "'" + usuario.getPasswordUser() + "'"
                    + ");"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
                return 0;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        public bool ExcluirUsuario(int idUsuario)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                    "DELETE FROM usuarios WHERE id_usuario = '" + idUsuario + "'"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir usuário: " + ex.Message);
                return false;
            }
            finally
            {
                this.FecharConexao("");
            }
        }

        public bool AlterarUsuario(MUsers usuario)
        {
            try
            {
                this.Conectar();
                return this.ExecutarUpdateDelet(
                    "UPDATE usuarios SET "
                        + "nome = '" + usuario.getNameUser() + "', "
                        + "email = '" + usuario.getEmailUser() + "', "
                        + "login_user = '" + usuario.getLoginUser() + "', "
                        + "senha_user = '" + usuario.getPasswordUser() + "' "
                        + "WHERE id_usuario = '" + usuario.getIdUser() + "'"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar usuário: " + ex.Message);
                return false;
            }
            finally
            {
                MessageBox.Show(usuario.getNameUser());
                this.FecharConexao("");
            }
        }

        public MUsers RetornarUsuario(int idUsuario)
        {
            MUsers usuario = new MUsers();

            try
            {
                this.Conectar();
                this.ExecultarConsulta(
                    "SELECT "
                    + "id_usuario, "
                    + "nome, "
                    + "email, "
                    + "login_user, "
                    + "senha_user "
                    + "FROM usuarios WHERE id_usuario = '" + idUsuario + "';"
                );

                while (this.GetResultSet().NextResult())
                {
                    usuario.setIdUser(this.GetResultSet().GetInt32(0));
                    usuario.setNameUser(this.GetResultSet().GetString(1));
                    usuario.setEmailUser(this.GetResultSet().GetString(2));
                    usuario.setLoginUser(this.GetResultSet().GetString(3));
                    usuario.setPasswordUser(this.GetResultSet().GetString(4));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar usuário: " + ex.Message);
            }
            finally
            {
                this.FecharConexao("");
            }

            return usuario;
        }

    }
}
