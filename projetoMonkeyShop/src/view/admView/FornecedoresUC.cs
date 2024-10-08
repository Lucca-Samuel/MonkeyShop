using projetoMonkeyShop.src.controller;
using projetoMonkeyShop.src.model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view.admView
{
    public partial class FornecedoresUC : UserControl
    {
        CFornecedores cFornecedor = new CFornecedores();
        MFornecedores mFornecedor = new MFornecedores();
        public string salvarAlterar;

        public FornecedoresUC()
        {
            InitializeComponent();
            tbxIdFornecedor.Enabled = false;
            //this.Visible = false;
            //this.Hide();
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            this.SalvarFornecedor();
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo);

            if(confirmacao == DialogResult.Yes)
            {
                this.LimparCampos();
            }
        }

        private void LimparCampos()
        {
            tbxNomeFor.Text = ("");
            tbxCNPJ.Text = ("");
            tbxProdutoFor.Text = ("");
            tbxTelefone.Text = ("");
            tbxCelular.Text = ("");
            tbxEmail.Text = ("");
            tbxContato.Text = ("");
            tbxCEP.Text = ("");
            tbxLogradouro.Text = ("");
            tbxNumero.Text = ("");
            tbxBairro.Text = ("");
            tbxCidade.Text = ("");
            tbxEstado.Text = ("");
            tbxLogradouro.Text = ("");
            tbxFornecedorInfos.Text = ("");
        }

        private void SalvarFornecedor()
        {
            mFornecedor.setNomeFantasiaFornecedor(this.tbxNomeFor.Text);
            mFornecedor.setCnpjFornecedor(this.tbxCNPJ.Text);
            mFornecedor.setProdutoFornecedor(this.tbxProdutoFor.Text);
            mFornecedor.setTelefoneFornecedor(this.tbxTelefone.Text);
            mFornecedor.setCelularFornecedor(this.tbxCelular.Text);
            mFornecedor.setEmailFornecedor(this.tbxEmail.Text);
            mFornecedor.setNomeContatoFornecedor(this.tbxContato.Text);
            mFornecedor.setCepFornecedor(this.tbxCEP.Text);
            mFornecedor.setLogradouroFornecedor(this.tbxLogradouro.Text);
            mFornecedor.setNumeroLogradouroFornecedor(int.Parse(this.tbxNumero.Text));
            mFornecedor.setBairroFornecedor(this.tbxBairro.Text);
            mFornecedor.setCidadeFornecedor(this.tbxCidade.Text);
            mFornecedor.setUfFornecedor(this.tbxEstado.Text);
            mFornecedor.setComplementoLogradouroFornecedor(this.tbxLogradouro.Text);
            mFornecedor.setInfoImportantFornecedor(this.tbxFornecedorInfos.Text);

            try
            {
                if(cFornecedor.salvarProdutoC(mFornecedor) > 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimparCampos();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Fornecedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
