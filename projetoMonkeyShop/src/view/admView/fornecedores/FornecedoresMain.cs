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
    public partial class FornecedoresMain : UserControl
    {
        FornecedoresUC fornecedores = new FornecedoresUC();


        public FornecedoresMain()
        {
            InitializeComponent();
        }

        private void btnCriarFor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmForenecedores frmForenecedores = new FrmForenecedores();
                frmForenecedores.Show();

                fornecedores.salvarAlterar = "novo";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
