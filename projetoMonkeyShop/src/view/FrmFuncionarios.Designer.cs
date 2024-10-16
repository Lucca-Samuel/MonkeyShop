namespace projetoMonkeyShop.src.view
{
    partial class FrmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarios));
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnCriarUser = new System.Windows.Forms.Button();
            this.btnExcluirUser = new System.Windows.Forms.Button();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(712, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 44);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(3, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(824, 75);
            this.gbxSearch.TabIndex = 21;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Pesquisa Por Nome";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(4, 21);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(694, 44);
            this.tbxSearch.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(7, 132);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(813, 349);
            this.dgvUsers.TabIndex = 22;
            // 
            // btnCriarUser
            // 
            this.btnCriarUser.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCriarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCriarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarUser.Image = global::projetoMonkeyShop.Properties.Resources._new;
            this.btnCriarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarUser.Location = new System.Drawing.Point(718, 512);
            this.btnCriarUser.Name = "btnCriarUser";
            this.btnCriarUser.Size = new System.Drawing.Size(110, 50);
            this.btnCriarUser.TabIndex = 23;
            this.btnCriarUser.Text = "Novo";
            this.btnCriarUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarUser.UseVisualStyleBackColor = false;
            this.btnCriarUser.Click += new System.EventHandler(this.btnCriarUser_Click);
            // 
            // btnExcluirUser
            // 
            this.btnExcluirUser.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluirUser.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirUser.Image")));
            this.btnExcluirUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirUser.Location = new System.Drawing.Point(591, 512);
            this.btnExcluirUser.Name = "btnExcluirUser";
            this.btnExcluirUser.Size = new System.Drawing.Size(110, 50);
            this.btnExcluirUser.TabIndex = 25;
            this.btnExcluirUser.Text = "Excluir";
            this.btnExcluirUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirUser.UseVisualStyleBackColor = false;
            this.btnExcluirUser.Click += new System.EventHandler(this.btnExcluirUser_Click);
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 574);
            this.Controls.Add(this.btnCriarUser);
            this.Controls.Add(this.btnExcluirUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSearch);
            this.Name = "FrmFuncionarios";
            this.Text = "FrmFuncionarios";
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnCriarUser;
        private System.Windows.Forms.Button btnExcluirUser;
    }
}