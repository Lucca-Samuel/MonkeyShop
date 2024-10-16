using projetoMonkeyShop.src.dao;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMonkeyShop.src.controller
{
    internal class CUsers
    {
        DaoUsers daoUsuarios = new DaoUsers();

        public int SalvarUsuario(MUsers usuario)
        {
            return this.daoUsuarios.CadastrarUsuario(usuario);
        }

        public bool ExcluirUsuario(int idUsuario)
        {
            return this.daoUsuarios.ExcluirUsuario(idUsuario);
        }

        public bool AlterarUsuario(MUsers usuario)
        {
            return this.daoUsuarios.AlterarUsuario(usuario);
        }

        public MUsers RetornarUsuario(int idUsuario)
        {
            return this.daoUsuarios.RetornarUsuario(idUsuario);
        }
    }
}
