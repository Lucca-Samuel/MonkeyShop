using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMonkeyShop.src.view.admView.fornecedores
{
    public partial class FornecedoresInitial : Form
    {
        FrmCadastroFornecedores frmcadastroFornecedores = new FrmCadastroFornecedores();

        public FornecedoresInitial()
        {
            InitializeComponent();
        }

        private void btnCriarFor_Click(object sender, EventArgs e)
        {
            frmcadastroFornecedores.salvarAlterar = "salvar";
            frmcadastroFornecedores.Show();
        }

        private void btnAlterarFor_Click(object sender, EventArgs e)
        {
            frmcadastroFornecedores.salvarAlterar = "alterar";
            frmcadastroFornecedores.Show();
        }

        private void btnCancelarFor_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirFor_Click(object sender, EventArgs e)
        {

        }


    }
}
