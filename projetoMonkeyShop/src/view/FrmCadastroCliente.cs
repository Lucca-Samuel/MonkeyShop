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
    public partial class FrmCadastroCliente : Form
    {
        MClientes mClientes = new MClientes();
        CClientes cClientes = new CClientes();

        private FrmClientes frmClientes;

        public string salvarAlterar;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            tbxCodigo.Enabled = false;
        }

        private void LimparCampos()
        {
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");

            tbxCodigo.Text = ("");
            tbxNome.Text = ("");
            tbxSobrenome.Text = ("");
            tbxCpf.Text = ("");
            tbxRg.Text = ("");
            tbxTelefone.Text = ("");
            tbxCelular.Text = ("");
            tbxEmail.Text = ("");
            cbxPessoaT.Text = ("");
            tbxCep.Text = ("");
            tbxLogradouro.Text = ("");
            tbxNumero.Text = ("");
            tbxBairro.Text = ("");
            tbxCidade.Text = ("");
            cbxUf.Text = ("");
            tbxLogradouro.Text = ("");
            tbxComplemento.Text = ("");
            tbxPais.Text = ("");
            dtpNascimento.Text = (dataFormatada);
        }

        private void SalvarCliente()
        {
            mClientes.SetName(this.tbxNome.Text);
            mClientes.SetSobrenome(this.tbxSobrenome.Text);
            mClientes.SetCpf(this.tbxCpf.Text);
            mClientes.SetRg(this.tbxRg.Text);
            mClientes.SetTelefone(this.tbxTelefone.Text);
            mClientes.SetCelular(this.tbxCelular.Text);
            mClientes.SetEmail(this.tbxEmail.Text);
            mClientes.SetTipoClie(this.cbxPessoaT.Text);
            mClientes.SetCep(this.tbxCep.Text);
            mClientes.SetLogradouro(this.tbxLogradouro.Text);
            mClientes.SetNumeroLog(int.Parse(this.tbxNumero.Text));
            mClientes.SetBairro(this.tbxBairro.Text);
            mClientes.SetCidade(this.tbxCidade.Text);
            mClientes.SetUf(this.cbxUf.Text);
            mClientes.SetComplemento(this.tbxComplemento.Text);
            mClientes.SetPais(this.tbxPais.Text);
            mClientes.SetDataNascimento(DateTime.Parse(this.dtpNascimento.Text)); // Ajuste conforme necessário

            try
            {
                if (cClientes.SalvarCliente(mClientes) > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimparCampos();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        public void AlterarCliente()
        {
            mClientes.SetIdCliente(int.Parse(this.tbxCodigo.Text));
            mClientes.SetName(this.tbxNome.Text);
            mClientes.SetSobrenome(this.tbxSobrenome.Text);
            mClientes.SetCpf(this.tbxCpf.Text);
            mClientes.SetRg(this.tbxRg.Text);
            mClientes.SetTelefone(this.tbxTelefone.Text);
            mClientes.SetCelular(this.tbxCelular.Text);
            mClientes.SetEmail(this.tbxEmail.Text);
            mClientes.SetCep(this.tbxCep.Text);
            mClientes.SetLogradouro(this.tbxLogradouro.Text);
            mClientes.SetNumeroLog(int.Parse(this.tbxNumero.Text));
            mClientes.SetBairro(this.tbxBairro.Text);
            mClientes.SetCidade(this.tbxCidade.Text);
            mClientes.SetUf(this.cbxUf.Text);
            mClientes.SetComplemento(this.tbxComplemento.Text);
            mClientes.SetTipoClie(this.cbxPessoaT.Text);
            mClientes.SetPais(this.tbxPais.Text);


            if (cClientes.AlterarCliente(mClientes))
            {
                MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao alterar os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        public void LoadClientes(DataGridViewRow selectedRow)
        {
            try
            {

                tbxCodigo.Text = selectedRow.Cells["id_cliente"].Value.ToString();
                tbxNome.Text = selectedRow.Cells["nome"].Value.ToString();
                tbxSobrenome.Text = selectedRow.Cells["sobrenome"].Value.ToString();
                tbxCpf.Text = selectedRow.Cells["cpf"].Value.ToString();
                tbxRg.Text = selectedRow.Cells["rg"].Value.ToString();
                tbxTelefone.Text = selectedRow.Cells["telefone"].Value.ToString();
                tbxCelular.Text = selectedRow.Cells["whatsapp"].Value.ToString();
                tbxEmail.Text = selectedRow.Cells["email"].Value.ToString();
                cbxPessoaT.Text = selectedRow.Cells["tipo_cliente"].Value.ToString();
                tbxCep.Text = selectedRow.Cells["cep"].Value.ToString();
                tbxLogradouro.Text = selectedRow.Cells["logradouro"].Value.ToString();
                tbxNumero.Text = selectedRow.Cells["numero"].Value.ToString();
                tbxComplemento.Text = selectedRow.Cells["complemento"].Value.ToString();
                tbxBairro.Text = selectedRow.Cells["bairro"].Value.ToString();
                tbxCidade.Text = selectedRow.Cells["cidade"].Value.ToString();
                cbxUf.Text = selectedRow.Cells["estado"].Value.ToString();
                tbxPais.Text = selectedRow.Cells["pais"].Value.ToString();
                dtpNascimento.Value = DateTime.Parse(selectedRow.Cells["data_nascimento"].Value.ToString());

            tbxCodigo.Enabled = false; // Ou tbxIdCliente.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Código inválido ou registro não selecionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (salvarAlterar == "alterar")
            {
                this.AlterarCliente();
            }
            else if (salvarAlterar == "salvar")
            {
                this.SalvarCliente();
            }
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                this.LimparCampos();
            }
        }
    }
}
