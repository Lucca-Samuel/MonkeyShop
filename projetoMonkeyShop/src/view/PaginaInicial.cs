using projetoMonkeyShop.src.view.admView;
using projetoMonkeyShop.src.view.admView.fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            try
            {
                Venda vendaForm = new Venda();

                vendaForm.Show();

            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoque estoqueView = new FrmEstoque();

                estoqueView.Show();

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedoresInitial fornecedoresInitial = new FornecedoresInitial();
                fornecedoresInitial.Show();
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }
    }
}
