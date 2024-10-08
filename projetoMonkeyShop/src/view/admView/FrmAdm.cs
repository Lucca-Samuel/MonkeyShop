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
    public partial class FrmAdm : Form
    {
        public FrmAdm()
        {
            InitializeComponent();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FornecedoresUC fornecedores = new FornecedoresUC();
            fornecedores.BringToFront(); // Leva o controle para frente
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresUC1_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuFornecedor1_Load(object sender, EventArgs e)
        {

        }
    }
}
