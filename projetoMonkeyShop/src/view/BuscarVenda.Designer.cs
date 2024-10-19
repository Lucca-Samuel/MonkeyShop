namespace projetoMonkeyShop.src.view
{
    partial class BuscarVenda
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
            this.tbxBuscarVenda = new System.Windows.Forms.TextBox();
            this.lblBuscarVenda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dtpFilter = new System.Windows.Forms.DateTimePicker();
            this.cbxCatFilter = new System.Windows.Forms.ComboBox();
            this.cbxCorFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscarVenda
            // 
            this.tbxBuscarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarVenda.Location = new System.Drawing.Point(12, 50);
            this.tbxBuscarVenda.Name = "tbxBuscarVenda";
            this.tbxBuscarVenda.Size = new System.Drawing.Size(882, 35);
            this.tbxBuscarVenda.TabIndex = 3;
            // 
            // lblBuscarVenda
            // 
            this.lblBuscarVenda.AutoSize = true;
            this.lblBuscarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarVenda.Location = new System.Drawing.Point(7, 18);
            this.lblBuscarVenda.Name = "lblBuscarVenda";
            this.lblBuscarVenda.Size = new System.Drawing.Size(162, 29);
            this.lblBuscarVenda.TabIndex = 2;
            this.lblBuscarVenda.Text = "Buscar Venda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(900, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(12, 471);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(1028, 258);
            this.dgvVendas.TabIndex = 6;
            // 
            // dtpFilter
            // 
            this.dtpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilter.Location = new System.Drawing.Point(12, 113);
            this.dtpFilter.Name = "dtpFilter";
            this.dtpFilter.Size = new System.Drawing.Size(310, 24);
            this.dtpFilter.TabIndex = 7;
            // 
            // cbxCatFilter
            // 
            this.cbxCatFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxCatFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCatFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCatFilter.FormattingEnabled = true;
            this.cbxCatFilter.Items.AddRange(new object[] {
            "Camisas",
            "Blusas",
            "T-shirts",
            "Regatas",
            "Saias",
            "Calças",
            "Shorts",
            "Bermudas",
            "Macacões",
            "Jaquetas",
            "Casacos",
            "Cardigans",
            "Suéteres",
            "Bonés",
            "Chapéus",
            "Meias",
            "Bolsas",
            "Shoulder Bags",
            "Mochilas",
            "Óculos de sol"});
            this.cbxCatFilter.Location = new System.Drawing.Point(328, 113);
            this.cbxCatFilter.Name = "cbxCatFilter";
            this.cbxCatFilter.Size = new System.Drawing.Size(233, 24);
            this.cbxCatFilter.TabIndex = 8;
            // 
            // cbxCorFilter
            // 
            this.cbxCorFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxCorFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCorFilter.FormattingEnabled = true;
            this.cbxCorFilter.Items.AddRange(new object[] {
            "Aqua",
            "Azul",
            "Azul claro",
            "Azul escuro",
            "Bege",
            "Bordô",
            "Branco",
            "Caramelo",
            "Ciano",
            "Cinza",
            "Cinza claro",
            "Cinza escuro",
            "Dourado",
            "Laranja",
            "Lavanda",
            "Marrom",
            "Mostarda",
            "Pêssego",
            "Petroleo",
            "Preto",
            "Prata",
            "Rosa",
            "Rosa claro",
            "Roxo",
            "Salmon",
            "Sépia",
            "Terracota",
            "Turquesa",
            "Verde",
            "Verde claro",
            "Verde escuro",
            "Vermelho",
            "Vinho"});
            this.cbxCorFilter.Location = new System.Drawing.Point(567, 113);
            this.cbxCorFilter.Name = "cbxCorFilter";
            this.cbxCorFilter.Size = new System.Drawing.Size(233, 24);
            this.cbxCorFilter.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // BuscarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCorFilter);
            this.Controls.Add(this.cbxCatFilter);
            this.Controls.Add(this.dtpFilter);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxBuscarVenda);
            this.Controls.Add(this.lblBuscarVenda);
            this.Name = "BuscarVenda";
            this.Text = "BuscarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBuscarVenda;
        private System.Windows.Forms.Label lblBuscarVenda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DateTimePicker dtpFilter;
        private System.Windows.Forms.ComboBox cbxCatFilter;
        private System.Windows.Forms.ComboBox cbxCorFilter;
        private System.Windows.Forms.Label label1;
    }
}