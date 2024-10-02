namespace projetoMonkeyShop.src.view.admView
{
    partial class FornecedoresUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxDadosBasicos = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbxDadosBasicos
            // 
            this.gbxDadosBasicos.Location = new System.Drawing.Point(13, 12);
            this.gbxDadosBasicos.Name = "gbxDadosBasicos";
            this.gbxDadosBasicos.Size = new System.Drawing.Size(816, 108);
            this.gbxDadosBasicos.TabIndex = 0;
            this.gbxDadosBasicos.TabStop = false;
            this.gbxDadosBasicos.Text = "Dados Básicos";
            // 
            // FornecedoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gbxDadosBasicos);
            this.Name = "FornecedoresUC";
            this.Size = new System.Drawing.Size(841, 741);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosBasicos;
    }
}
