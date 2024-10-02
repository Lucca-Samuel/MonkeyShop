using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.model
{
    internal class MMensagens
    {
        private int id_msg;
        private string assunto;
        private DateTime data_msg;
        private string msg;
        private int id_usuario;

        public int getIdMensagem()
        {
            return id_msg;
        }

        public string getAssunto()
        {
            return assunto;
        }

        public DateTime getDataMsg()
        {
            return data_msg;
        }

        public string getMsg()
        {
            return msg;
        }

        public int getId_usuario()
        {
            return id_usuario;
        }

        public void setDataMsg(DateTime dataMsg)
        {
            this.data_msg = dataMsg;
        }

        public void setMsg(string msg)
        {
            this.msg = msg;
        }

        public void setAssunto(string assunto)
        {
            this.assunto = assunto;
        }

    }
}
