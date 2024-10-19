using projetoMonkeyShop.src.controller;
using projetoMonkeyShop.src.dao;
using projetoMonkeyShop.src.model;
using projetoMonkeyShop.src.view.admView.fornecedores;
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
    public partial class FrmClientes : Form
    {
        CClientes cClientes = new CClientes();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnCriarClie_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.salvarAlterar = "salvar";
            frmCadastroCliente.ShowDialog();
        }

        private void btnAlterarClie_Click(object sender, EventArgs e)
        {
            if(dgvClies.Rows.Count > 0)
            {
                FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
                frmCadastroCliente.salvarAlterar = "alterar";

                frmCadastroCliente.LoadClientes(dgvClies.SelectedRows[0]);
                frmCadastroCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para Atualizar");
            }
        }

        private void btnExcluirClie_Click(object sender, EventArgs e)
        {
            //Verifica se há uma linha selecionada
            if (this.dgvClies.CurrentRow == null)
            {
                MessageBox.Show("Nenhum cliente selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int linha = this.dgvClies.CurrentRow.Index;

            // Tenta obter o valor do código do fornecedor
            object valor = this.dgvClies.Rows[linha].Cells[0].Value;

            // Verifica se o valor não é nulo e pode ser convertido para inteiro
            if (valor == null || !int.TryParse(valor.ToString(), out int codigoFornecedor))
            {
                MessageBox.Show("Código do cliente inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                if (cClientes.ExcluirCliente(codigoFornecedor))
                {
                    MessageBox.Show("Cliente excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao tentar excluir cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cm.CommandText = "SELECT id_cliente, nome, sobrenome, telefone, whatsapp, email, cpf, data_nascimento, rg, tipo_cliente, cep, logradouro, numero, complemento, bairro, cidade, estado, pais " +
                                     "FROM clientes WHERE nome LIKE ('%" + tbxSearch.Text + "%') OR cpf LIKE ('%" + tbxSearch.Text + "%')";

                    da.SelectCommand = cm;
                    da.Fill(dy);

                    dgvClies.DataSource = dy;
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
                cm.CommandText = "SELECT * FROM clientes";
                da.SelectCommand = cm;
                da.Fill(dy);

                dgvClies.DataSource = dy;
            }
        }
    }
}
