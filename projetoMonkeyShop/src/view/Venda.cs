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
        private CVendas cVendas = new CVendas();
        private CVendasRelation cVendaRl = new CVendasRelation();
        private MVendas mVendas= new MVendas();
        private MVendaRelation mVendaRl= new MVendaRelation();

        public Venda()
        {
            InitializeComponent();
            carrinho = new List<CarrinhoVenda>();

            tbxValorTotal.Enabled = false;
            tbxQtdeItens.Enabled = false;
            tbxDesconto.Text = "0";
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
            string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;";
            //string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select pro_id, pro_cod, pro_nome, pro_preco from tbl_produtos where pro_cod like('%" + tbxInclusao.Text + "')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        produto.SetIdProduto(reader.GetInt32(0));
                        produto.SetCodProduto(reader.GetInt32(1));
                        produto.SetNomeProduto(reader.GetString(2));
                        object precoObj = reader.GetValue(3);
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
                idProduto = i.produto.getIdProduto(),
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

        private void AtualizarValorFinal()
        {
            double valorTotal;
            double desconto;

            // Tente converter o valor total
            if (double.TryParse(tbxValorTotal.Text, out valorTotal))
            {
                // Verifica se o desconto está vazio ou é igual a 0
                if (string.IsNullOrWhiteSpace(tbxDesconto.Text) || tbxDesconto.Text == "0")
                {
                    // Se o desconto for vazio ou 0, o valor final é o mesmo que o valor total
                    tbxValorFinal.Text = valorTotal.ToString("F2");
                }
                else
                {
                    // Tente converter o valor do desconto
                    if (double.TryParse(tbxDesconto.Text, out desconto))
                    {
                        // Calcula o valor final
                        double valorFinal = valorTotal - desconto;
                        tbxValorFinal.Text = valorFinal.ToString("F2"); // Atualiza o TextBox de valor final
                    }
                    else
                    {
                        // Se a conversão do desconto falhar, exiba uma mensagem ou trate o erro
                        MessageBox.Show("Desconto inválido.");
                    }
                }
            }
            else
            {
                // Se a conversão do valor total falhar, trate o erro
                MessageBox.Show("Valor total inválido.");
            }
        }

        private void tbxDesconto_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorFinal();
        }
        ///////////////////////////////////////////////Fim dá área do carrinho///////////////////////////////////////////////////////////////////////////////

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Limpa a fonte de dados
            tbxValorTotal.Text = ("");
            tbxQtdeItens.Text = ("");
        }


        public void Salvarvenda()
        {
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");

            mVendas.SetDataVenda(DateTime.Parse(dataFormatada));
            mVendas.SetValorTotalVenda(double.Parse(tbxValorFinal.Text));
            mVendas.SetFkIdFormaPgto(cbxFormPgto.Text);
            //mVendas.SetFkIdCliente(int.Parse());
            //mVendas.SetFkIdUser(int.Parse());
            try
            {
                if(cVendas.salvarVenda(mVendas) > 0)
                {
                    MessageBox.Show("Venda realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = null; // Limpa a fonte de dados
                    tbxValorTotal.Text = ("");
                    tbxQtdeItens.Text = ("");
                    tbxValorFinal.Text = ("");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao realizar venda", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private bool VerificarIdsProdutosExistentes(List<int> idsProdutos)
        {
            string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;";
            //string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var id in idsProdutos)
                {
                    string query = "SELECT COUNT(*) FROM tbl_produtos WHERE pro_id = @idProduto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idProduto", id);
                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            return false; // ID não existe
                        }
                    }
                }
            }
            return true; // Todos os IDs existem
        }


        public void SalvarVendaRl()
        {
            
            List<int> idsProdutos = ObterIdsProdutosDoDataGridView();

            foreach (var id in idsProdutos)
            {
                mVendaRl.SetFkIdProduto(id); // Chama o método com cada ID
            }

            int ultimoIdVenda = ObterUltimoIdVenda();
            mVendaRl.SetFkIdVenda(ultimoIdVenda);

            double desconto;
            if (double.TryParse(tbxDesconto.Text, out desconto))
            {
                mVendaRl.SetDesconto(desconto);
            }
            else
            {
                MessageBox.Show("Desconto inválido. Por favor, insira um valor numérico.");
            }

            List<int> quantidades = ObterQuantidadesDoCarrinho();
            foreach (var quantidade in quantidades)
            {
                mVendaRl.SetQtdeProdutos(quantidade); // Chama o método para cada quantidade
            }

            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
            mVendaRl.SetData(DateTime.Parse(dataFormatada));

            try
            {
                if(cVendaRl.SalvarVendaRelation(mVendaRl) > 0)
                {
                    MessageBox.Show("sucesso");

                    dataGridView1.DataSource = null; // Limpa a fonte de dados
                    tbxValorTotal.Text = ("");
                    tbxQtdeItens.Text = ("");
                    tbxDesconto.Text = ("0");
                    tbxValorFinal.Text = ("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<int> ObterIdsProdutosDoDataGridView()
        {
            List<int> idsProdutos = new List<int>();

            // Itera sobre as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idProduto"].Value != null)
                {
                    // Adiciona o ID à lista
                    idsProdutos.Add(Convert.ToInt32(row.Cells["idProduto"].Value));
                }
            }

            return idsProdutos;
        }

        private int ObterUltimoIdVenda()
        {
            int ultimoIdVenda = 0;

            string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;";
            //string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=Lucca-pc;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(id_venda) FROM vendas"; // Consulta para obter o maior id_venda

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object resultado = cmd.ExecuteScalar(); // Executa a consulta e obtém o resultado

                    if (resultado != DBNull.Value) // Verifica se o resultado não é nulo
                    {
                        ultimoIdVenda = Convert.ToInt32(resultado); // Converte para int
                    }
                }
            }

            return ultimoIdVenda; // Retorna o último ID de venda
        }

        private List<int> ObterQuantidadesDoCarrinho()
        {
            List<int> quantidades = new List<int>(); // Lista para armazenar as quantidades

            // Itera sobre as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Quantidade"].Value != null) // Verifica se a célula não é nula
                {
                    // Adiciona a quantidade à lista
                    quantidades.Add(Convert.ToInt32(row.Cells["Quantidade"].Value)); // Converte o valor para int
                }
            }

            return quantidades; // Retorna a lista de quantidades
        }

        private void AtualizarEstoqueProdutos()
        {
            string connectionString = @"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=monkey_shop;Server=TAU0588413W10-1;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var item in carrinho)
                {
                    int idProduto = item.produto.getIdProduto();
                    int quantidade = item.qtde;

                    // Query para subtrair a quantidade
                    string query = "UPDATE tbl_produtos SET pro_qtd = pro_qtd - @quantidade WHERE pro_id = @idProduto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@idProduto", idProduto);

                        // Executa a atualização
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            this.Salvarvenda();
            int ex = mVendaRl.GetFkIdProduto();
            MessageBox.Show(ex.ToString());
            

            List<int> idsProdutos = ObterIdsProdutosDoDataGridView();
            if (VerificarIdsProdutosExistentes(idsProdutos))
            {
                this.SalvarVendaRl();
                this.AtualizarEstoqueProdutos();
            }
            else
            {
                MessageBox.Show("Um ou mais produtos não existem no estoque. Verifique e tente novamente.");
            }
        }
    }
}
