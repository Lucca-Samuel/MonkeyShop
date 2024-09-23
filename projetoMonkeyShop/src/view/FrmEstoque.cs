using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using projetoMonkeyShop.src.model;
using projetoMonkeyShop.src.controller;


namespace projetoMonkeyShop.src.view
{
    public partial class FrmEstoque : Form
    {

        List<MProdutos> listaModelProdutos = new List<MProdutos>();
        CProdutos cProdutos = new CProdutos();
        MProdutos mProdutos = new MProdutos();
        string salvarAlterar;


        public FrmEstoque()
        {
            InitializeComponent();
            HabilitarCampos(false);
            this.tbxId.Enabled = false;
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxCodInc_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxProdName_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbxModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxCor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbxQtd_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbxPreco_TextChanged(object sender, EventArgs e)
        {
        }

        /**
        * Informa que será cadastrado um novo produto
        */
        private void btnCriarProd_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            this.LimparCampos();
            salvarAlterar = "salvar";
        }

        /**
        * Informa que será alterado um produto
        */

        //!!INCOMPLETO!!
        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            salvarAlterar = "alterar";
        }

        /**
       * Salva o produto no banco
       */
        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if (salvarAlterar.Equals("salvar"))
            {
                this.SalvarProdutos();
            }
            else if (salvarAlterar.Equals("alterar"))
            {
                this.AlterarProdutos();
            }
        }

        private void HabilitarCampos(bool status)
        {
            tbxCodInc.Enabled = status;
            tbxProdName.Enabled = status;
            cbxCategoria.Enabled = status;
            tbxModelo.Enabled = status;
            cbxTamanho.Enabled = status;
            cbxCor.Enabled = status;
            tbxQtd.Enabled = status;
            cbxStatus.Enabled = status;
            tbxPreco.Enabled = status;
        }

        /**
        * Limpa os campos do formulario
        * @param status 
        */
        private void LimparCampos()
        {
            tbxCodInc.Text = ("");
            cbxCategoria.Text = ("");
            tbxModelo.Text = ("");
            cbxTamanho.Text = ("");
            cbxCor.Text = ("");
            tbxQtd.Text = ("");
            cbxStatus.Text = ("");
            tbxPreco.Text = ("");
            tbxProdName.Text = ("");
        }

        private void SalvarProdutos()
        {
            mProdutos.SetCodProduto(int.Parse(this.tbxCodInc.Text));
            mProdutos.SetCategoriaProduto(this.cbxCategoria.Text);
            mProdutos.SetModeloProduto(this.tbxModelo.Text);
            mProdutos.SetTamanhoProduto(this.cbxTamanho.Text);
            mProdutos.SetCorProduto(this.cbxCor.Text);
            mProdutos.SetQtdProduto(int.Parse(this.tbxQtd.Text));
            mProdutos.SetStatusProduto(this.cbxStatus.Text);
            mProdutos.SetPrecoProduto(double.Parse(tbxPreco.Text));
            mProdutos.SetNomeProduto(tbxProdName.Text);

            if (cProdutos.salvarProdutoC(mProdutos) > 0)
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LimparCampos();
                this.HabilitarCampos(false);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produtos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterarProdutos()
        {
            mProdutos.SetCodProduto(int.Parse(this.tbxCodInc.Text));
            mProdutos.SetCategoriaProduto(this.cbxCategoria.Text);
            mProdutos.SetModeloProduto(this.tbxModelo.Text);
            mProdutos.SetTamanhoProduto(this.cbxTamanho.Text);
            mProdutos.SetCorProduto(this.cbxCor.Text);
            mProdutos.SetQtdProduto(int.Parse(this.tbxQtd.Text));
            mProdutos.SetStatusProduto(this.cbxStatus.Text);
            mProdutos.SetPrecoProduto(double.Parse(tbxPreco.Text));

            if (cProdutos.alterarProdutoC(mProdutos))
            {
                MessageBox.Show("Produto Alterado com sucesso com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LimparCampos();
                this.HabilitarCampos(false);
            }
            else
            {
                MessageBox.Show("Erro ao alterar produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
