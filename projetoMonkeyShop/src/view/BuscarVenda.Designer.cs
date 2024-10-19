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
            this.dtpData1Filter = new System.Windows.Forms.DateTimePicker();
            this.cbxCatFilter = new System.Windows.Forms.ComboBox();
            this.cbxCorFilter = new System.Windows.Forms.ComboBox();
            this.cbxTamFilter = new System.Windows.Forms.ComboBox();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.cbxPgtoFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData2Filter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTypeFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.gbxFiltros.SuspendLayout();
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
            this.dgvVendas.Location = new System.Drawing.Point(12, 320);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(1028, 258);
            this.dgvVendas.TabIndex = 6;
            // 
            // dtpData1Filter
            // 
            this.dtpData1Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1Filter.Location = new System.Drawing.Point(4, 43);
            this.dtpData1Filter.Name = "dtpData1Filter";
            this.dtpData1Filter.Size = new System.Drawing.Size(310, 24);
            this.dtpData1Filter.TabIndex = 7;
            this.dtpData1Filter.Value = new System.DateTime(2024, 10, 1, 0, 0, 0, 0);
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
            this.cbxCatFilter.Location = new System.Drawing.Point(320, 107);
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
            this.cbxCorFilter.Location = new System.Drawing.Point(636, 47);
            this.cbxCorFilter.Name = "cbxCorFilter";
            this.cbxCorFilter.Size = new System.Drawing.Size(233, 24);
            this.cbxCorFilter.TabIndex = 8;
            // 
            // cbxTamFilter
            // 
            this.cbxTamFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxTamFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTamFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamFilter.FormattingEnabled = true;
            this.cbxTamFilter.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG",
            "XG",
            "XGG"});
            this.cbxTamFilter.Location = new System.Drawing.Point(875, 47);
            this.cbxTamFilter.Name = "cbxTamFilter";
            this.cbxTamFilter.Size = new System.Drawing.Size(153, 24);
            this.cbxTamFilter.TabIndex = 8;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.cbxPgtoFilter);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label3);
            this.gbxFiltros.Controls.Add(this.label7);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.label5);
            this.gbxFiltros.Controls.Add(this.label6);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Controls.Add(this.cbxTamFilter);
            this.gbxFiltros.Controls.Add(this.cbxCatFilter);
            this.gbxFiltros.Controls.Add(this.cbxTypeFilter);
            this.gbxFiltros.Controls.Add(this.cbxCorFilter);
            this.gbxFiltros.Controls.Add(this.dtpData2Filter);
            this.gbxFiltros.Controls.Add(this.dtpData1Filter);
            this.gbxFiltros.Location = new System.Drawing.Point(12, 91);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(1036, 223);
            this.gbxFiltros.TabIndex = 9;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtrar por";
            // 
            // cbxPgtoFilter
            // 
            this.cbxPgtoFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxPgtoFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPgtoFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPgtoFilter.FormattingEnabled = true;
            this.cbxPgtoFilter.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Débito",
            "Crédito a vista",
            "Crédito parcelado"});
            this.cbxPgtoFilter.Location = new System.Drawing.Point(4, 107);
            this.cbxPgtoFilter.Name = "cbxPgtoFilter";
            this.cbxPgtoFilter.Size = new System.Drawing.Size(310, 24);
            this.cbxPgtoFilter.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(872, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamanho do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cor do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categoria do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Mínima de venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Forma de Pagamento";
            // 
            // dtpData2Filter
            // 
            this.dtpData2Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2Filter.Location = new System.Drawing.Point(320, 43);
            this.dtpData2Filter.Name = "dtpData2Filter";
            this.dtpData2Filter.Size = new System.Drawing.Size(310, 24);
            this.dtpData2Filter.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Máxima de venda";
            // 
            // cbxTypeFilter
            // 
            this.cbxTypeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxTypeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTypeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeFilter.FormattingEnabled = true;
            this.cbxTypeFilter.Items.AddRange(new object[] {
            "Mais Vendido",
            "Menos Vendido",
            "Maior Valor",
            "Menor Valor"});
            this.cbxTypeFilter.Location = new System.Drawing.Point(559, 107);
            this.cbxTypeFilter.Name = "cbxTypeFilter";
            this.cbxTypeFilter.Size = new System.Drawing.Size(469, 24);
            this.cbxTypeFilter.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Filtros Padrão";
            // 
            // BuscarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 741);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxBuscarVenda);
            this.Controls.Add(this.lblBuscarVenda);
            this.Controls.Add(this.gbxFiltros);
            this.Name = "BuscarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBuscarVenda;
        private System.Windows.Forms.Label lblBuscarVenda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DateTimePicker dtpData1Filter;
        private System.Windows.Forms.ComboBox cbxCatFilter;
        private System.Windows.Forms.ComboBox cbxCorFilter;
        private System.Windows.Forms.ComboBox cbxTamFilter;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPgtoFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpData2Filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTypeFilter;
    }
}