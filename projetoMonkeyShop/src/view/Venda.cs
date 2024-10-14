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
        }

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
        }

        private MProdutos ObterProdutoPorCodigo(int codigo)
        {
             MProdutos produto = new MProdutos();
            string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;";

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
                        produto.SetPrecoProduto(reader.GetDouble(2));
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
        }
    }
}
