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

        }

        private void SalvarFornecedor()
        {
            mFornecedor.setNomeFantasiaFornecedor(this.tbxNomeFor.Text);
            mFornecedor.setCnpjFornecedor(this.tbxCNPJ.Text);
            mFornecedor.setProdutoFornecedor(this.tbxProdutoFor.Text);
            mFornecedor.setTelefoneFornecedor(this.tbxTelefone.Text);
            mFornecedor.setCelularFornecedor(this.tbxCelular.Text);
            mFornecedor.setEmailFornecedor(this.tbxEmail.Text);
            mFornecedor.setNomeContatoFornecedor(this.tbxNomeFor.Text);
        }
    }
}
