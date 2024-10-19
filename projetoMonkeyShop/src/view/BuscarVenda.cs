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
            //using (SqlConnection cn = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;"))
            {
                using (SqlCommand cm = new SqlCommand())
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dy = new DataTable();

                    try
                    {
                        cm.Connection = cn;
                        cn.Open();

                        if (!string.IsNullOrEmpty(tbxBuscarVenda.Text))
                        {
                            // Consulta SQL filtrando pelo CPF do cliente
                            cm.CommandText = @"
                    SELECT 
                        c.cpf AS CPF,
                        c.nome AS Cliente,
                        c.whatsapp AS Celular,
                        p.pro_cod AS [Código Produto],
                        p.pro_nome AS Produto,
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
                        c.cpf = @cpf;"; // Filtrando pelo CPF do cliente

                            // Adicionando o parâmetro
                            cm.Parameters.AddWithValue("@cpf", tbxBuscarVenda.Text);
                        }
                        else
                        {
                            // Consulta SQL trazendo todos os registros de venda ordenados pela data
                            cm.CommandText = @"
                            SELECT 
                                c.cpf AS CPF,
                                c.nome AS Cliente,
                                c.whatsapp AS Celular,
                                p.pro_cod AS [Código Produto],
                                p.pro_nome AS Produto,
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
                            ORDER BY 
                                v.data_venda DESC;"; // Ordenando pela data mais recente
                        }

                        da.SelectCommand = cm;
                        da.Fill(dy);

                        // Limpando o DataGridView antes de preencher
                        dgvVendas.DataSource = dy;

                        // Renomeando colunas
                        dgvVendas.Columns["CPF"].HeaderText = "CPF";
                        dgvVendas.Columns["Cliente"].HeaderText = "Cliente";
                        dgvVendas.Columns["Celular"].HeaderText = "Celular";
                        dgvVendas.Columns["Código Produto"].HeaderText = "Código Produto";
                        dgvVendas.Columns["Produto"].HeaderText = "Produto";
                        dgvVendas.Columns["Preço Produto"].HeaderText = "Preço Produto";
                        dgvVendas.Columns["Data Vendido"].HeaderText = "Data Vendido";
                        dgvVendas.Columns["Desconto"].HeaderText = "Desconto";
                        dgvVendas.Columns["Valor Total"].HeaderText = "Valor Total";
                        dgvVendas.Columns["Forma de Pagamento"].HeaderText = "Forma de Pagamento";
                        dgvVendas.Columns["Quantidade Vendida"].HeaderText = "Quantidade Vendida";
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
