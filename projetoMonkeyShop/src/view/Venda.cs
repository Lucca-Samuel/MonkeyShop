using projetoMonkeyShop.src.controller;
using projetoMonkeyShop.src.model;
using projetoMonkeyShop.src.util;
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
    public partial class Venda : Form
    {

        private List<CarrinhoVenda> carrinho;

        public Venda()
        {
            InitializeComponent();
            carrinho = new List<CarrinhoVenda>();

            tbxValorTotal.Enabled = false;
            tbxQtdeItens.Enabled = false;
        }


        //Começo da área do carrinho
        private void btnOk_Click(object sender, EventArgs e)
        {
            int codigoProduto;
            if (int.TryParse(tbxInclusao.Text, out codigoProduto))
            {
                MProdutos produto = ObterProdutoPorCodigo(codigoProduto);
                if (produto != null)
                {
                    var itemExistente = carrinho.FirstOrDefault(i => i.produto.getCodProduto() == codigoProduto);

                    if (itemExistente != null)
                    {
                        // Se já existe, aumenta a quantidade
                        itemExistente.qtde++;
                    }
                    else
                    {
                        carrinho.Add(new CarrinhoVenda
                        {
                            produto = produto,
                            qtde = 1
                        });
                    }
                    AtualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Código de produto inválido.");
            }

            tbxInclusao.Text = "";
        }

        private MProdutos ObterProdutoPorCodigo(int codigo)
        {
             MProdutos produto = new MProdutos();
            //string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;";
            string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select pro_cod, pro_nome, pro_preco from tbl_produtos where pro_cod like('%" + tbxInclusao.Text + "')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        produto.SetCodProduto(reader.GetInt32(0));
                        produto.SetNomeProduto(reader.GetString(1));
                        object precoObj = reader.GetValue(2);
                        if (precoObj is decimal precoDecimal)
                        {
                            produto.SetPrecoProduto(Convert.ToDouble(precoDecimal));
                        }
                        else if (precoObj is double precoDouble)
                        {
                            produto.SetPrecoProduto(precoDouble);
                        }
                        else
                        {
                            // Trate o caso em que o valor não é compatível
                            throw new InvalidCastException("O tipo do preço não é compatível.");
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return produto;
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.DataSource = null; // Limpa a fonte de dados
            dataGridView1.DataSource = carrinho.Select(i => new
            {
                CodigoProduto = i.produto.getCodProduto(),
                NomeProduto = i.produto.getNomeProduto(),
                Preco = i.produto.getPrecoProduto(),
                Quantidade = i.qtde,
                Total = i.produto.getPrecoProduto() * i.qtde
            }).ToList();

            tbxValorTotal.Text = CalcularTotalGeral().ToString("F2");
            tbxQtdeItens.Text = CalcularQuantidadeTotal().ToString();
        }

        private double CalcularTotalGeral()
        {
            return carrinho.Sum(item => item.produto.getPrecoProduto() * item.qtde);
        }

        private int CalcularQuantidadeTotal()
        {
            return carrinho.Sum(item => item.qtde);
        }

        private void tbxInclusao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick(); // Simula o clique no botão "OK"
                e.SuppressKeyPress = true;
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.E) // Verifica se Ctrl está pressionado e a tecla E
            {
                FrmEstoqueAux frmEstoqueAux = new FrmEstoqueAux();
                frmEstoqueAux.ShowDialog();
                e.SuppressKeyPress = true;
            }
        }
        //Fim dá área do carrinho

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Limpa a fonte de dados
            tbxValorTotal.Text = ("");
            tbxQtdeItens.Text = ("");
        }
    }
}
