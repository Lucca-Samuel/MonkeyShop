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
            frmcadastroFornecedores.Show();
        }

        private void btnAlterarFor_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedores frmcadastroFornecedores = new FrmCadastroFornecedores();
            frmcadastroFornecedores.salvarAlterar = "alterar";
            //frmcadastroFornecedores.loadFornecedores(); // Carregue os dados antes de mostrar
            frmcadastroFornecedores.Show();
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
            SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;");

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

        //!!Incompleto!!
        public void loadFornecedores()
        {
            FrmCadastroFornecedores frmcadastroFornecedores = new FrmCadastroFornecedores();
            int linha = this.dgvFornecedores.CurrentRow.Index;
            
                try
                {
                    frmcadastroFornecedores.tbxIdFornecedor.Text = dgvFornecedores.SelectedRows[linha].Cells[0].Value.ToString();
                    frmcadastroFornecedores.tbxNomeFor.Text = dgvFornecedores.SelectedRows[linha].Cells[1].Value.ToString();
                    frmcadastroFornecedores.tbxCNPJ.Text = dgvFornecedores.SelectedRows[linha].Cells[2].Value.ToString();
                    frmcadastroFornecedores.tbxProdutoFor.Text = dgvFornecedores.SelectedRows[linha].Cells[3].Value.ToString();
                    frmcadastroFornecedores.tbxTelefone.Text = dgvFornecedores.SelectedRows[linha].Cells[4].Value.ToString();
                    frmcadastroFornecedores.tbxCelular.Text = dgvFornecedores.SelectedRows[linha].Cells[5].Value.ToString();
                    frmcadastroFornecedores.tbxEmail.Text = dgvFornecedores.SelectedRows[linha].Cells[6].Value.ToString();
                    frmcadastroFornecedores.tbxContato.Text = dgvFornecedores.SelectedRows[linha].Cells[7].Value.ToString();
                    frmcadastroFornecedores.tbxCEP.Text = dgvFornecedores.SelectedRows[linha].Cells[8].Value.ToString();
                    frmcadastroFornecedores.tbxLogradouro.Text = dgvFornecedores.SelectedRows[linha].Cells[9].Value.ToString();
                    frmcadastroFornecedores.tbxNumero.Text = dgvFornecedores.SelectedRows[linha].Cells[10].Value.ToString();
                    frmcadastroFornecedores.tbxComplemento.Text= dgvFornecedores.SelectedRows[linha].Cells[11].Value.ToString();
                    frmcadastroFornecedores.tbxBairro.Text = dgvFornecedores.SelectedRows[linha].Cells[12].Value.ToString();
                    frmcadastroFornecedores.tbxCidade.Text = dgvFornecedores.SelectedRows[linha].Cells[13].Value.ToString();
                    frmcadastroFornecedores.tbxEstado.Text = dgvFornecedores.SelectedRows[linha].Cells[14].Value.ToString();
                    frmcadastroFornecedores.tbxFornecedorInfos.Text = dgvFornecedores.SelectedRows[linha].Cells[15].Value.ToString();

                    frmcadastroFornecedores.tbxIdFornecedor.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Código invalido ou Registro não selecionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
