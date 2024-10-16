namespace projetoMonkeyShop.src.view
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.dgvClies = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCriarClie = new System.Windows.Forms.Button();
            this.btnAlterarClie = new System.Windows.Forms.Button();
            this.btnExcluirClie = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClies)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClies
            // 
            this.dgvClies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClies.Location = new System.Drawing.Point(12, 110);
            this.dgvClies.Name = "dgvClies";
            this.dgvClies.Size = new System.Drawing.Size(810, 290);
            this.dgvClies.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(4, 21);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(694, 44);
            this.tbxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(712, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCriarClie
            // 
            this.btnCriarClie.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCriarClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCriarClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarClie.Image = global::projetoMonkeyShop.Properties.Resources._new;
            this.btnCriarClie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarClie.Location = new System.Drawing.Point(712, 512);
            this.btnCriarClie.Name = "btnCriarClie";
            this.btnCriarClie.Size = new System.Drawing.Size(110, 50);
            this.btnCriarClie.TabIndex = 16;
            this.btnCriarClie.Text = "Novo";
            this.btnCriarClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarClie.UseVisualStyleBackColor = false;
            this.btnCriarClie.Click += new System.EventHandler(this.btnCriarClie_Click);
            // 
            // btnAlterarClie
            // 
            this.btnAlterarClie.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAlterarClie.Image = global::projetoMonkeyShop.Properties.Resources.edit;
            this.btnAlterarClie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarClie.Location = new System.Drawing.Point(585, 512);
            this.btnAlterarClie.Name = "btnAlterarClie";
            this.btnAlterarClie.Size = new System.Drawing.Size(110, 50);
            this.btnAlterarClie.TabIndex = 17;
            this.btnAlterarClie.Text = "Alterar";
            this.btnAlterarClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarClie.UseVisualStyleBackColor = false;
            this.btnAlterarClie.Click += new System.EventHandler(this.btnAlterarClie_Click);
            // 
            // btnExcluirClie
            // 
            this.btnExcluirClie.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluirClie.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirClie.Image")));
            this.btnExcluirClie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirClie.Location = new System.Drawing.Point(469, 512);
            this.btnExcluirClie.Name = "btnExcluirClie";
            this.btnExcluirClie.Size = new System.Drawing.Size(110, 50);
            this.btnExcluirClie.TabIndex = 18;
            this.btnExcluirClie.Text = "Excluir";
            this.btnExcluirClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirClie.UseVisualStyleBackColor = false;
            this.btnExcluirClie.Click += new System.EventHandler(this.btnExcluirClie_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(3, 13);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(826, 75);
            this.gbxSearch.TabIndex = 19;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Pesquisa Por CPF";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 574);
            this.Controls.Add(this.btnCriarClie);
            this.Controls.Add(this.btnAlterarClie);
            this.Controls.Add(this.btnExcluirClie);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvClies);
            this.Controls.Add(this.gbxSearch);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClies)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClies;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCriarClie;
        private System.Windows.Forms.Button btnAlterarClie;
        private System.Windows.Forms.Button btnExcluirClie;
        private System.Windows.Forms.GroupBox gbxSearch;
    }
}