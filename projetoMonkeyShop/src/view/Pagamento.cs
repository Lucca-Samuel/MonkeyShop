using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view
{
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
            this.habilitarCampos(false);
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void habilitarCampos(bool status)
        {
            this.tbxCredito.Enabled = status;
            this.tbxDebito.Enabled = status;
            this.tbxDinheiro.Enabled = status;
            this.tbxPix.Enabled = status;
        }

        public void limparCampos()
        {
            this.tbxCredito.Text = ("");
            this.tbxDebito.Text = ("");
            this.tbxDinheiro.Text = ("");
            this.tbxPix.Text = ("");
        }
    }
}
