using projetoMonkeyShop.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view
{
    public partial class FrmFuncionarios : Form
    {
        CUsers cUsers = new CUsers();
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCriarUser_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            //Verifica se há uma linha selecionada
            if (this.dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Nenhum cliente selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int linha = this.dgvUsers.CurrentRow.Index;

            // Tenta obter o valor do código do fornecedor
            object valor = this.dgvUsers.Rows[linha].Cells[0].Value;

            // Verifica se o valor não é nulo e pode ser convertido para inteiro
            if (valor == null || !int.TryParse(valor.ToString(), out int codigoFornecedor))
            {
                MessageBox.Show("Código do Usuário inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja excluir este Usuário?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                if (cUsers.ExcluirUsuario(codigoFornecedor))
                {
                    MessageBox.Show("Usuário excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao tentar excluir Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;");
            SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;");
            //TAU0588413W10-1
            //TAU0588423W10-1

            SqlCommand cm = new SqlCommand();

            SqlDataReader dt;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dy = new DataTable();

            if (tbxSearch.Text != "")
            {
                try
                {
                    cm.Connection = cn;
                    cn.Open();
                    cm.CommandText = "SELECT id_usuario, nome, email, login_user " +
                                     "FROM usuarios WHERE nome LIKE ('%" + tbxSearch.Text + "%')";

                    da.SelectCommand = cm;
                    da.Fill(dy);

                    dgvUsers.DataSource = dy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                cm.Connection = cn;
                cn.Open();
                cm.CommandText = "SELECT id_usuario, nome, email, login_user FROM usuarios";
                da.SelectCommand = cm;
                da.Fill(dy);

                dgvUsers.DataSource = dy;
            }
        }
    }
}
