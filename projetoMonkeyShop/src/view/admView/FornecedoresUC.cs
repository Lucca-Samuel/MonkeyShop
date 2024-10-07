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

namespace projetoMonkeyShop.src.view.admView
{
    public partial class FornecedoresUC : UserControl
    {
        CFornecedores cFornecedor = new CFornecedores();
        MFornecedores mFornecedor = new MFornecedores();
        string salvarAlterar;

        public FornecedoresUC()
        {
            InitializeComponent();
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            this.SalvarFornecedor();
        }

        private void HabilitarCampos(bool status)
        {
            tbxNomeFor.Enabled = status;
            tbxCNPJ.Enabled = status;
            tbxProdutoFor.Enabled = status;
            tbxTelefone.Enabled = status;
            tbxCelular.Enabled = status;
            tbxEmail.Enabled = status;
            tbxContato.Enabled = status;
            tbxCEP.Enabled = status;
            tbxLogradouro.Enabled = status;
            tbxNumero.Enabled = status;
            tbxBairro.Enabled = status;
            tbxCidade.Enabled = status;
            tbxEstado.Enabled = status;
            tbxLogradouro.Enabled = status;
            tbxFornecedorInfos.Enabled = status;
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
                    this.HabilitarCampos(false);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Fornecedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
