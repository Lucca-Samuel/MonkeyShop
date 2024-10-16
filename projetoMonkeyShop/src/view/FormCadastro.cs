using projetoMonkeyShop.src.controller;
using projetoMonkeyShop.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view
{
    public partial class FormCadastro : Form
    {
        MUsers mUsers = new MUsers();
        CUsers cUsers = new CUsers();

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.SalvarUser();
        }

        public void SalvarUser()
        {
            mUsers.setNameUser(tbxNome.Text);
            mUsers.setEmailUser(tbxEmail.Text);
            mUsers.setLoginUser(tbxLogin.Text);
            mUsers.setPasswordUser(tbxSenha.Text);

            try
            {
                // Verifica se as senhas coincidem
                if (tbxSenha.Text != tbxConfirmarSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cUsers.SalvarUsuario(mUsers) > 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.LimparCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Usuário", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadUsuarios(DataGridViewRow selectedRow)
        {
            try
            {
                tbxNome.Text = selectedRow.Cells["nome"].Value.ToString();
                tbxEmail.Text = selectedRow.Cells["email"].Value.ToString();
                tbxLogin.Text = selectedRow.Cells["login_user"].Value.ToString();
                tbxSenha.Text = selectedRow.Cells["senha_user"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Código inválido ou registro não selecionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
