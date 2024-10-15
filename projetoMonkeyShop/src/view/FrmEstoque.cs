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
using System.Data.SqlClient;


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
        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            salvarAlterar = "alterar";
            int linha = this.dgvProdutos.CurrentRow.Index;

            try
            {
                tbxId.Text = dgvProdutos.SelectedRows[0].Cells[0].Value.ToString();
                tbxCodInc.Text = dgvProdutos.SelectedRows[0].Cells[1].Value.ToString();
                tbxProdName.Text = dgvProdutos.SelectedRows[0].Cells[2].Value.ToString();
                cbxCategoria.Text = dgvProdutos.SelectedRows[0].Cells[3].Value.ToString();
                tbxModelo.Text = dgvProdutos.SelectedRows[0].Cells[4].Value.ToString();
                cbxTamanho.Text = dgvProdutos.SelectedRows[0].Cells[5].Value.ToString();
                cbxCor.Text = dgvProdutos.SelectedRows[0].Cells[6].Value.ToString();
                tbxQtd.Text = dgvProdutos.SelectedRows[0].Cells[7].Value.ToString();
                cbxStatus.Text = dgvProdutos.SelectedRows[0].Cells[8].Value.ToString();
                tbxPreco.Text = dgvProdutos.SelectedRows[0].Cells[9].Value.ToString();

                
                //int codigoProduto = (int)this.dgvProdutos.Rows[linha].Cells[0].Value;
                //mProdutos = cProdutos.retornarProdutoC(codigoProduto);
                //tbxId.Text = mProdutos.getIdProduto().ToString();
                //tbxCodInc.Text = mProdutos.getCodProduto().ToString();
                //tbxProdName.Text = mProdutos.getNomeProduto();
                //cbxCategoria.Text = mProdutos.getCategoriaProduto();
                //tbxModelo.Text = mProdutos.getModeloProduto();
                //cbxTamanho.Text = mProdutos.getTamanhoProduto();
                //cbxCor.Text = mProdutos.getCorProduto();
                //tbxQtd.Text = mProdutos.getQtdProduto().ToString();
                //cbxStatus.Text = mProdutos.getStatusProduto();
                //tbxPreco.Text = mProdutos.getPrecoProduto().ToString();
                 

                tbxCodInc.Enabled = false;
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

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            int linha = this.dgvProdutos.CurrentRow.Index;
            int codigoProduto = (int)this.dgvProdutos.Rows[linha].Cells[0].Value;
            DialogResult confirmacao = MessageBox.Show(this, "Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo);
            
            if(confirmacao == DialogResult.Yes)
            {
                if (cProdutos.excluirProdutoC(codigoProduto))
                {
                    MessageBox.Show("Produto excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao tentar excluir produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Operação cancelada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HabilitarCampos(false);
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;");

            SqlCommand cm = new SqlCommand();

            SqlDataReader dt;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dy = new DataTable();

            if (tbxBuscarProd.Text != "")
            {
                try
                {
                    cm.Connection= cn;
                    cn.Open();
                    cm.CommandText = "select pro_id, pro_cod, pro_nome, pro_categoria, pro_modelo, pro_tamanho, pro_cor, pro_qtd, pro_status, pro_preco from tbl_produtos where pro_cod like('%" + tbxBuscarProd.Text + "')";


                    da.SelectCommand = cm;
                    da.Fill(dy);

                    dgvProdutos.DataSource = dy;
                }catch(Exception ex)
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
                cm.CommandText = "SELECT pro_id, pro_cod, pro_nome, pro_categoria, pro_modelo, pro_tamanho, pro_cor, pro_qtd, pro_status, pro_preco FROM tbl_produtos";
                da.SelectCommand = cm;
                da.Fill(dy);

                dgvProdutos.DataSource = dy;
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
            mProdutos.SetIdProduto(int.Parse(this.tbxId.Text));
            mProdutos.SetCodProduto(long.Parse(this.tbxCodInc.Text));
            mProdutos.SetCategoriaProduto(this.cbxCategoria.Text);
            mProdutos.SetModeloProduto(this.tbxModelo.Text);
            mProdutos.SetTamanhoProduto(this.cbxTamanho.Text);
            mProdutos.SetCorProduto(this.cbxCor.Text);
            mProdutos.SetQtdProduto(int.Parse(this.tbxQtd.Text));
            mProdutos.SetStatusProduto(this.cbxStatus.Text);
            mProdutos.SetPrecoProduto(double.Parse(tbxPreco.Text));
            mProdutos.SetNomeProduto(tbxProdName.Text);

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
    }
}
