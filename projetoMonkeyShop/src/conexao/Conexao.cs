using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projetoMonkeyShop.src.view;
using System.Windows.Forms;
using System.Data;

namespace projetoMonkeyShop.src.conexao
{
    internal class Conexao
    {
        private bool status = false;
        private string mensagem = "";   //variavel que vai informar o status da conexao
        private SqlConnection con = null;  //variavel para conexao
        private SqlCommand cm = null; //variavel para comandos sql
        private SqlDataReader dt = null; //variavel para consulta sql



        //private string servidor = "Lucca-pc";
        private string servidor = "TAU0588413W10-1";
        //private string servidor = "TAU0588423W10-1";
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
            catch(SqlException ex) {
                status = false;
                mensagem = $"Falha ao conectar com o banco: {ex.Message}";
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

            try
            {
                cm = new SqlCommand(pSql, con);

                dt = cm.ExecuteReader();
            }
            catch (SqlException exception) {

                MessageBox.Show(exception.Message);

                Console.WriteLine(exception.StackTrace);

                return false;

            }
            return true;
        }


        public bool ExecutarUpdateDelet (string pSql) {
            try
            {
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                
                cm= new SqlCommand(pSql, con);

                cm.ExecuteNonQuery();

            }
            catch(SqlException exception) {
                MessageBox.Show(exception.Message);
                return false;
            }
            return true;
        }

        public int ExecutarInsert(string pSql) {
            int status = 0;
            cm = null;
            try
            {
                cm = new SqlCommand(pSql, GetCon());
                cm.ExecuteNonQuery();

                // Consultar o último ID inserido
                cm.CommandText = "SELECT SCOPE_IDENTITY();";

                // Executar a consulta e recuperar o último ID inserido
                status = Convert.ToInt32(cm.ExecuteScalar());

            }
            catch(SqlException exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.ToString());
            }
            return status;
        }

        public bool FecharConexao(string pSql)
        {
            try
            {
                if(dt != null && cm != null){
                dt.Close();
                cm.Dispose();
                }

                if(con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                return true;

            }catch(SqlException exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SetMensagem(string mensagem)
        {
            this.mensagem = mensagem;
        }

        public void SetCon(SqlConnection con)
        {
            this.con = con;
        }

        public void SetStatement(SqlCommand statement)
        {
            this.cm = statement;
        }

        public void SetResultSet(SqlDataReader resultSet)
        {
            this.dt = resultSet;
        }

        public void SetServidor(string servidor)
        {
            this.servidor = servidor;
        }

        public void SetNomeDoBanco(string nomeDoBanco)
        {
            this.nomeDoBanco = nomeDoBanco;
        }

        public void SetUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetMensagem()
        {
            return this.mensagem;
        }

        public SqlConnection GetCon()
        {
            return this.con;
        }

        public SqlCommand GetStatement()
        {
            return this.cm;
        }

        public SqlDataReader GetResultSet()
        {
            return this.dt;
        }

        public string GetServidor()
        {
            return this.servidor;
        }

        public string GetNomeDoBanco()
        {
            return this.nomeDoBanco;
        }

        public string GetUsuario()
        {
            return this.usuario;
        }

        public string GetSenha()
        {
            return this.senha;
        }

    }
}
