using projetoMonkeyShop.src.dao;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetoMonkeyShop.src.view
{
    public partial class BuscarVenda : Form
    {
        public BuscarVenda()
        {
            InitializeComponent();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;"))
            {
                using (SqlCommand cm = new SqlCommand())
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dy = new DataTable();

                    try
                    {
                        cm.Connection = cn;
                        cn.Open();

                        // Base da consulta
                        cm.CommandText = @"
                            SELECT 
                                c.cpf AS CPF,
                                c.nome AS Cliente,
                                c.whatsapp AS Celular,
                                p.pro_cod AS [Código Produto],
                                p.pro_nome AS Produto,
                                p.pro_cor AS Cor,
                                p.pro_tamanho AS Tamanho,
                                p.pro_preco AS [Preço Produto],
                                v.data_venda AS [Data Vendido],
                                rv.desconto AS Desconto,
                                v.valor_total AS [Valor Total],
                                v.fk_id_forma_pgto AS [Forma de Pagamento],
                                rv.qtde_vendida AS [Quantidade Vendida]
                            FROM 
                                vendas v
                            JOIN 
                                rl_produtos_vendas rv ON v.id_venda = rv.fk_id_venda
                            JOIN 
                                clientes c ON v.fk_id_cliente = c.id_cliente
                            JOIN 
                                tbl_produtos p ON rv.fk_id_produto = p.pro_id
                            WHERE 
                                (@dataInicial IS NULL OR v.data_venda >= @dataInicial) AND
                                (@dataFinal IS NULL OR v.data_venda <= @dataFinal) AND
                                (@cor IS NULL OR p.pro_cor = @cor) AND
                                (@tamanho IS NULL OR p.pro_tamanho = @tamanho) AND
                                (@formaPgto IS NULL OR v.fk_id_forma_pgto = @formaPgto) AND
                                (@categoria IS NULL OR p.pro_categoria = @categoria)";

                        // Adicionando os parâmetros
                        cm.Parameters.AddWithValue("@dataInicial", dtpData1Filter.Value.Date == DateTime.MinValue ? (object)DBNull.Value : dtpData1Filter.Value.Date);
                        cm.Parameters.AddWithValue("@dataFinal", dtpData2Filter.Value.Date == DateTime.MinValue ? (object)DBNull.Value : dtpData2Filter.Value.Date);
                        cm.Parameters.AddWithValue("@cor", cbxCorFilter.SelectedItem != null ? cbxCorFilter.SelectedItem.ToString() : (object)DBNull.Value);
                        cm.Parameters.AddWithValue("@tamanho", cbxTamFilter.SelectedItem != null ? cbxTamFilter.SelectedItem.ToString() : (object)DBNull.Value);
                        cm.Parameters.AddWithValue("@formaPgto", cbxPgtoFilter.SelectedItem != null ? cbxPgtoFilter.SelectedItem.ToString() : (object)DBNull.Value);
                        cm.Parameters.AddWithValue("@categoria", cbxCatFilter.SelectedItem != null ? cbxCatFilter.SelectedItem.ToString() : (object)DBNull.Value);


                        // Adicionando a ordenação
                        if (cbxTypeFilter.Text == "Mais Vendido")
                        {
                            cm.CommandText += " ORDER BY rv.qtde_vendida DESC;";
                        }
                        else if (cbxTypeFilter.Text == "Menos Vendido")
                        {
                            cm.CommandText += " ORDER BY rv.qtde_vendida ASC;";
                        }
                        else if (cbxTypeFilter.Text == "Maior Valor")
                        {
                            cm.CommandText += " ORDER BY p.pro_preco DESC;";
                        }
                        else if (cbxTypeFilter.Text == "Menor Valor")
                        {
                            cm.CommandText += " ORDER BY p.pro_preco ASC;";
                        }
                        else
                        {
                            cm.CommandText += " ORDER BY v.data_venda DESC;"; // Padrão
                        }

                        da.SelectCommand = cm;
                        da.Fill(dy);

                        // Limpando o DataGridView antes de preencher
                        if (dy.Rows.Count > 0)
                        {
                            dgvVendas.DataSource = dy;

                            // Renomeando colunas
                            dgvVendas.Columns["CPF"].HeaderText = "CPF";
                            dgvVendas.Columns["Cliente"].HeaderText = "Cliente";
                            dgvVendas.Columns["Celular"].HeaderText = "Celular";
                            dgvVendas.Columns["Código Produto"].HeaderText = "Código Produto";
                            dgvVendas.Columns["Produto"].HeaderText = "Produto";
                            dgvVendas.Columns["Cor"].HeaderText = "Cor";
                            dgvVendas.Columns["Tamanho"].HeaderText = "Tamanho";
                            dgvVendas.Columns["Preço Produto"].HeaderText = "Preço Produto";
                            dgvVendas.Columns["Data Vendido"].HeaderText = "Data Vendido";
                            dgvVendas.Columns["Desconto"].HeaderText = "Desconto";
                            dgvVendas.Columns["Valor Total"].HeaderText = "Valor Total";
                            dgvVendas.Columns["Forma de Pagamento"].HeaderText = "Forma de Pagamento";
                            dgvVendas.Columns["Quantidade Vendida"].HeaderText = "Quantidade Vendida";
                        }
                        else
                        {
                            dgvVendas.DataSource = null; // Limpa o DataGridView se não houver dados
                        }
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
            }
        }






    }
}
