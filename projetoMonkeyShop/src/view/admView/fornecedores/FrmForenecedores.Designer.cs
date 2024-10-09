namespace projetoMonkeyShop.src.view.admView.fornecedores
{
    partial class FrmForenecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fornecedoresUC1 = new projetoMonkeyShop.src.view.admView.FornecedoresUC();
            this.SuspendLayout();
            // 
            // fornecedoresUC1
            // 
            this.fornecedoresUC1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fornecedoresUC1.Location = new System.Drawing.Point(-5, -3);
            this.fornecedoresUC1.Name = "fornecedoresUC1";
            this.fornecedoresUC1.Size = new System.Drawing.Size(841, 682);
            this.fornecedoresUC1.TabIndex = 0;
            // 
            // FrmForenecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 670);
            this.Controls.Add(this.fornecedoresUC1);
            this.Name = "FrmForenecedores";
            this.Text = "FrmForenecedores";
            this.ResumeLayout(false);

        }

        #endregion

        private FornecedoresUC fornecedoresUC1;
    }
}