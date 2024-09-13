using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public SqlConnection conectar()
        {
            con = new SqlConnection(@"Persist Security Info=False;User ID= "+usuario+ ";Password= "+senha+ "; Initial Catalog= "+nomeDoBanco+ ";Server= "+servidor+";Encrypt=False;");
            return null;
        }
    }
}
