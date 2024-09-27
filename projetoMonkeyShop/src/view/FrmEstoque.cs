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
            //CarregarProdutos();
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

        private void tbxBuscarProd_TextChanged(object sender, EventArgs e)
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
         * Cancela a operação
        */
        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            this.LimparCampos();
        }

        /**
        * Informa que será alterado um produto
        */

        //!!INCOMPLETO!!
        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            salvarAlterar = "alterar";
            int linha = this.dgvProdutos.CurrentRow.Index;

            try
            {
                int codigoProduto = (int)this.dgvProdutos.Rows[linha].Cells[0].Value;

                mProdutos = cProdutos.retornarProdutoC(codigoProduto);

                tbxId.Text = mProdutos.getIdProduto().ToString();
                tbxCodInc.Text = mProdutos.getCodProduto().ToString();
                tbxProdName.Text = mProdutos.getNomeProduto();
                cbxCategoria.Text = mProdutos.getCategoriaProduto();
                tbxModelo.Text = mProdutos.getModeloProduto();
                cbxTamanho.Text = mProdutos.getTamanhoProduto();
                cbxCor.Text = mProdutos.getCorProduto();
                tbxQtd.Text = mProdutos.getQtdProduto().ToString();
                cbxStatus.Text = mProdutos.getStatusProduto();
                tbxPreco.Text = mProdutos.getPrecoProduto().ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Código invalido ou Registro não selecionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HabilitarCampos(false);
            }
        }

        /**
       * Salva o produto no banco
       */
        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if(tbxCodInc.Text == "" || tbxProdName.Text == "" || cbxCategoria.Text == "" || tbxProdName.Text == "" || cbxCor.Text == "" || tbxQtd.Text == "" || cbxStatus.Text == "" || tbxPreco.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
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
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            string pesquisaProduto = tbxBuscarProd.Text.Trim();

            // Verifica se o campo de pesquisa não está vazio e é numérico
            if (!string.IsNullOrEmpty(pesquisaProduto) && long.TryParse(pesquisaProduto, out long codProduto))
            {
                try
                {
                    // Chama o método para retornar o produto usando apenas o código
                    MProdutos produto = cProdutos.RetornarProdutosDGV(codProduto);

                    // Limpa a DataGridView antes de adicionar novos resultados
                    dgvProdutos.Rows.Clear();

                    // Verifica se o produto foi encontrado
                    if (produto != null && produto.getIdProduto() != 0)
                    {
                        // Adiciona o produto à DataGridView
                        dgvProdutos.Rows.Add(produto.getIdProduto(), produto.getCodProduto(), produto.getNomeProduto(),
                            produto.getCategoriaProduto(), produto.getModeloProduto(), produto.getTamanhoProduto(),
                            produto.getCorProduto(), produto.getQtdProduto(), produto.getStatusProduto(),
                            produto.getPrecoProduto());
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o produto: " + ex.Message);
                }
            }
            else
            {
                // Mensagem de erro se o código for inválido
                MessageBox.Show("Por favor, informe um código de produto válido.");
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
            
            mProdutos.SetCodProduto(long.Parse(this.tbxCodInc.Text));
            mProdutos.SetCategoriaProduto(this.cbxCategoria.Text);
            mProdutos.SetModeloProduto(this.tbxModelo.Text);
            mProdutos.SetTamanhoProduto(this.cbxTamanho.Text);
            mProdutos.SetCorProduto(this.cbxCor.Text);
            mProdutos.SetQtdProduto(int.Parse(this.tbxQtd.Text));
            mProdutos.SetStatusProduto(this.cbxStatus.Text);
            mProdutos.SetPrecoProduto(double.Parse(tbxPreco.Text));
            mProdutos.SetNomeProduto(tbxProdName.Text);

            try
            {
                if (cProdutos.salvarProdutoC(mProdutos) > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.CarregarProdutos();
                    this.LimparCampos();
                    this.HabilitarCampos(false);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produtos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
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
                //this.CarregarProdutos();
                this.LimparCampos();
                this.HabilitarCampos(false);
            }
            else
            {
                MessageBox.Show("Erro ao alterar produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*private void CarregarProdutos()
        {
            try
            {
                listaModelProdutos = cProdutos.retornarListaProdutoC();
                var modelo = (DataTable)dgvProdutos.DataSource;
                //modelo.Rows.Clear();

                for (int i = 0; i < listaModelProdutos.Count; i++)
                {

                    modelo.Rows.Add(new object[]
                    {
                    listaModelProdutos[i].getIdProduto(),
                    listaModelProdutos[i].getCodProduto(),
                    listaModelProdutos[i].getNomeProduto(),
                    listaModelProdutos[i].getModeloProduto(),
                    listaModelProdutos[i].getTamanhoProduto(),
                    listaModelProdutos[i].getCorProduto(),
                    listaModelProdutos[i].getQtdProduto(),
                    listaModelProdutos[i].getStatusProduto(),
                    listaModelProdutos[i].getPrecoProduto()
                    });
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/


    }
}
