using projetoMonkeyShop.src.controller;
using projetoMonkeyShop.src.dao;
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
using static System.Windows.Forms.LinkLabel;

namespace projetoMonkeyShop.src.view.admView.fornecedores
{
    public partial class FornecedoresInitial : Form
    {
        CFornecedores cFornecedores = new CFornecedores();

        public FornecedoresInitial()
        {
            InitializeComponent();
        }

        private void btnCriarFor_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedores frmcadastroFornecedores = new FrmCadastroFornecedores();
            frmcadastroFornecedores.salvarAlterar = "salvar";
            frmcadastroFornecedores.ShowDialog();
        }

        private void btnAlterarFor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                FrmCadastroFornecedores frmcadastroFornecedores = new FrmCadastroFornecedores();
                frmcadastroFornecedores.salvarAlterar = "alterar";

                // Carregar os dados antes de mostrar
                frmcadastroFornecedores.loadFornecedores(dgvFornecedores.SelectedRows[0]);

                frmcadastroFornecedores.ShowDialog(); // Abre como diálogo modal
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para alterar.");
            }
        }

        private void btnExcluirFor_Click(object sender, EventArgs e)
        {
            //Verifica se há uma linha selecionada
            if (this.dgvFornecedores.CurrentRow == null)
            {
                MessageBox.Show("Nenhum fornecedor selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int linha = this.dgvFornecedores.CurrentRow.Index;

            // Tenta obter o valor do código do fornecedor
            object valor = this.dgvFornecedores.Rows[linha].Cells[0].Value;

            // Verifica se o valor não é nulo e pode ser convertido para inteiro
            if (valor == null || !int.TryParse(valor.ToString(), out int codigoFornecedor))
            {
                MessageBox.Show("Código do fornecedor inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja excluir este fornecedor?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                if (cFornecedores.ExcluirFornecedor(codigoFornecedor))
                {
                    MessageBox.Show("Fornecedor excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao tentar excluir fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPesquisarFor_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;");
            SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;");
            //TAU0588413W10-1
            //TAU0588423W10-1

            SqlCommand cm = new SqlCommand();

            SqlDataReader dt;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dy = new DataTable();

            if (tbxPesquisa.Text != "")
            {
                try
                {
                    cm.Connection = cn;
                    cn.Open();
                    cm.CommandText = "SELECT id_fornecedor, nome_for, cnpj, pric_prod_for, telefone, whatsapp, email_for, nome_contato, cep, logradouro, numero, complemento, bairro, cidade, estado, important_infos FROM fornecedores WHERE nome_for Like('%" + tbxPesquisa.Text + "') OR cnpj LIKE ('%" + tbxPesquisa.Text + "%')";

                    da.SelectCommand = cm;
                    da.Fill(dy);

                    dgvFornecedores.DataSource = dy;
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
                cm.CommandText = "SELECT * FROM fornecedores";
                da.SelectCommand = cm;
                da.Fill(dy);

                dgvFornecedores.DataSource = dy;
            }
        }

    }
}
