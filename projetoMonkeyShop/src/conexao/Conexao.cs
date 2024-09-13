using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projetoMonkeyShop.src.view;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.conexao
{
    internal class Conexao
    {
        private bool status = false;
        private string mensagem = "";   //variavel que vai informar o status da conexao
        private SqlConnection con = null;  //variavel para conexao

        private string servidor = "TAU0588413W10-1";
        private string nomeDoBanco = "monkey_shop";
        private string usuario = "senac";
        private string senha = "senac";

        public void ConexaoSql(string pServidor, string pNomeDoBanco, string pUsuario, string pSenha)
        {
            this.servidor = pServidor;
            this.nomeDoBanco = pNomeDoBanco;
            this.usuario = pUsuario;
            this.senha = pSenha;
        }

        /**
        * Abre uma conexao com o banco
        * @return Connection
        */
        public SqlConnection Conectar()
        {
            try
            {
                con = new SqlConnection(@"Persist Security Info=False;User ID= " + usuario + ";Password= " + senha + "; Initial Catalog= " + nomeDoBanco + ";Server= " + servidor + ";Encrypt=False;");
                con.Open();
                status= true;
                mensagem = "Conexão bem sucedida";
            }
            catch {
                status= false;
                mensagem = "Falha ao conectar com o banco";
            }
            return con; 
        }

        /**
        * Executa consultas SQL
        * @param pSQL
        * @return int
        */
        public bool ExecultarConsulta(string pSql)
        {

            SqlCommand cm = null;
            SqlDataReader dt = null;

            try
            {
                cm = new SqlCommand(pSql, con);

                dt = cm.ExecuteReader();
            }
            catch (SqlException exception) {

                MessageBox.Show(exception.Message);

                Console.WriteLine(exception.StackTrace);

                return false;

            } finally
            {
                con.Close();
            } 
            return true;
        }


        public bool ExecutarUpdateDelet (string pSql) {
            try
            {

            }
            catch() {
            
            }
            return true;
        }

    }
}
