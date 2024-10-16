using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.model
{
    internal class MUsers
    {
        private int idUser;
        private string nameUser;
        private string emailUser;
        private string loginUser;
        private string passwordUser;

        public int getIdUser()
        {
            return idUser;
        }

        public void setIdUser(int value)
        {
            idUser = value;
        }

        public string getNameUser()
        {
            return nameUser;
        }

        public void setNameUser(string value)
        {
            nameUser = value;
        }

        public string getEmailUser()
        {
            return emailUser;
        }

        public void setEmailUser(string value)
        {
            emailUser = value;
        }

        public string getLoginUser()
        {
            return loginUser;
        }

        public void setLoginUser(string value)
        {
            loginUser = value;
        }

        public string getPasswordUser()
        {
            return passwordUser;
        }

        public void setPasswordUser(string value)
        {
            passwordUser = value;
        }
    }
}
