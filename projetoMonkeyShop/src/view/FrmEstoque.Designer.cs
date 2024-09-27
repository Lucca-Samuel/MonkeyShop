namespace projetoMonkeyShop.src.view
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxCodInc = new System.Windows.Forms.TextBox();
            this.tbxProdName = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.tbxQtd = new System.Windows.Forms.TextBox();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxBuscarProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnAlterarProd = new System.Windows.Forms.Button();
            this.btnCriarProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.cbxTamanho = new System.Windows.Forms.ComboBox();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(12, 29);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(99, 38);
            this.tbxId.TabIndex = 0;
            this.tbxId.TextChanged += new System.EventHandler(this.tbxId_TextChanged);
            // 
            // tbxCodInc
            // 
            this.tbxCodInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodInc.Location = new System.Drawing.Point(137, 29);
            this.tbxCodInc.Name = "tbxCodInc";
            this.tbxCodInc.Size = new System.Drawing.Size(736, 38);
            this.tbxCodInc.TabIndex = 0;
            this.tbxCodInc.TextChanged += new System.EventHandler(this.tbxCodInc_TextChanged);
            // 
            // tbxProdName
            // 
            this.tbxProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProdName.Location = new System.Drawing.Point(12, 113);
            this.tbxProdName.Name = "tbxProdName";
            this.tbxProdName.Size = new System.Drawing.Size(212, 38);
            this.tbxProdName.TabIndex = 0;
            this.tbxProdName.TextChanged += new System.EventHandler(this.tbxProdName_TextChanged);
            // 
            // tbxModelo
            // 
            this.tbxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModelo.Location = new System.Drawing.Point(482, 113);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(212, 38);
            this.tbxModelo.TabIndex = 0;
            this.tbxModelo.TextChanged += new System.EventHandler(this.tbxModelo_TextChanged);
            // 
            // tbxQtd
            // 
            this.tbxQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQtd.Location = new System.Drawing.Point(12, 196);
            this.tbxQtd.Name = "tbxQtd";
            this.tbxQtd.Size = new System.Drawing.Size(134, 38);
            this.tbxQtd.TabIndex = 0;
            this.tbxQtd.TextChanged += new System.EventHandler(this.tbxQtd_TextChanged);
            // 
            // tbxPreco
            // 
            this.tbxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPreco.Location = new System.Drawing.Point(412, 196);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(212, 38);
            this.tbxPreco.TabIndex = 0;
            this.tbxPreco.TextChanged += new System.EventHandler(this.tbxPreco_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod/Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tamanho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(880, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(408, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Preço";
            // 
            // tbxBuscarProd
            // 
            this.tbxBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarProd.Location = new System.Drawing.Point(12, 306);
            this.tbxBuscarProd.Name = "tbxBuscarProd";
            this.tbxBuscarProd.Size = new System.Drawing.Size(846, 38);
            this.tbxBuscarProd.TabIndex = 0;
            this.tbxBuscarProd.TextChanged += new System.EventHandler(this.tbxBuscarProd_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Buscar Produto";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(884, 306);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(139, 38);
            this.btnBuscarProd.TabIndex = 2;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Image = global::projetoMonkeyShop.Properties.Resources.cancel;
            this.btnCancelarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarProd.Location = new System.Drawing.Point(505, 673);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(110, 45);
            this.btnCancelarProd.TabIndex = 4;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarProd.UseVisualStyleBackColor = true;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click);
            // 
            // btnAlterarProd
            // 
            this.btnAlterarProd.Image = global::projetoMonkeyShop.Properties.Resources.edit;
            this.btnAlterarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarProd.Location = new System.Drawing.Point(634, 673);
            this.btnAlterarProd.Name = "btnAlterarProd";
            this.btnAlterarProd.Size = new System.Drawing.Size(110, 45);
            this.btnAlterarProd.TabIndex = 4;
            this.btnAlterarProd.Text = "Alterar";
            this.btnAlterarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarProd.UseVisualStyleBackColor = true;
            this.btnAlterarProd.Click += new System.EventHandler(this.btnAlterarProd_Click);
            // 
            // btnCriarProd
            // 
            this.btnCriarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCriarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarProd.Image = global::projetoMonkeyShop.Properties.Resources._new;
            this.btnCriarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarProd.Location = new System.Drawing.Point(900, 673);
            this.btnCriarProd.Name = "btnCriarProd";
            this.btnCriarProd.Size = new System.Drawing.Size(110, 45);
            this.btnCriarProd.TabIndex = 4;
            this.btnCriarProd.Text = "Novo";
            this.btnCriarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarProd.UseVisualStyleBackColor = true;
            this.btnCriarProd.Click += new System.EventHandler(this.btnCriarProd_Click);
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirProd.Image")));
            this.btnExcluirProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirProd.Location = new System.Drawing.Point(375, 673);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(110, 45);
            this.btnExcluirProd.TabIndex = 4;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.codProduto,
            this.nomeProduto,
            this.categoriaProduto,
            this.modeloProduto,
            this.tamanhoProduto,
            this.corProduto,
            this.qtdProduto,
            this.statusProduto,
            this.precoProduto});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 362);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(1011, 294);
            this.dgvProdutos.TabIndex = 5;
            // 
            // cbxTamanho
            // 
            this.cbxTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamanho.FormattingEnabled = true;
            this.cbxTamanho.Location = new System.Drawing.Point(719, 113);
            this.cbxTamanho.Name = "cbxTamanho";
            this.cbxTamanho.Size = new System.Drawing.Size(138, 39);
            this.cbxTamanho.TabIndex = 6;
            this.cbxTamanho.SelectedIndexChanged += new System.EventHandler(this.cbxTamanho_SelectedIndexChanged);
            // 
            // cbxCor
            // 
            this.cbxCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Location = new System.Drawing.Point(884, 113);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(92, 39);
            this.cbxCor.TabIndex = 6;
            this.cbxCor.SelectedIndexChanged += new System.EventHandler(this.cbxCor_SelectedIndexChanged);
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(172, 196);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(212, 39);
            this.cbxStatus.TabIndex = 6;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(245, 112);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(208, 39);
            this.cbxCategoria.TabIndex = 6;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProd.Image = global::projetoMonkeyShop.Properties.Resources.save1;
            this.btnSalvarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarProd.Location = new System.Drawing.Point(763, 673);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(110, 45);
            this.btnSalvarProd.TabIndex = 4;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProd.UseVisualStyleBackColor = true;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            // 
            // codProduto
            // 
            this.codProduto.HeaderText = "Cod/Barras";
            this.codProduto.Name = "codProduto";
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Produto";
            this.nomeProduto.Name = "nomeProduto";
            // 
            // categoriaProduto
            // 
            this.categoriaProduto.HeaderText = "Categoria";
            this.categoriaProduto.Name = "categoriaProduto";
            // 
            // modeloProduto
            // 
            this.modeloProduto.HeaderText = "Modelo";
            this.modeloProduto.Name = "modeloProduto";
            // 
            // tamanhoProduto
            // 
            this.tamanhoProduto.HeaderText = "Tamanho";
            this.tamanhoProduto.Name = "tamanhoProduto";
            // 
            // corProduto
            // 
            this.corProduto.HeaderText = "Cor";
            this.corProduto.Name = "corProduto";
            // 
            // qtdProduto
            // 
            this.qtdProduto.HeaderText = "QTD";
            this.qtdProduto.Name = "qtdProduto";
            // 
            // statusProduto
            // 
            this.statusProduto.HeaderText = "Status";
            this.statusProduto.Name = "statusProduto";
            // 
            // precoProduto
            // 
            this.precoProduto.HeaderText = "Preco";
            this.precoProduto.Name = "precoProduto";
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 741);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxTamanho);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnCriarProd);
            this.Controls.Add(this.btnSalvarProd);
            this.Controls.Add(this.btnAlterarProd);
            this.Controls.Add(this.btnExcluirProd);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBuscarProd);
            this.Controls.Add(this.tbxCodInc);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.tbxQtd);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.tbxProdName);
            this.Controls.Add(this.tbxId);
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxCodInc;
        private System.Windows.Forms.TextBox tbxProdName;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.TextBox tbxQtd;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxBuscarProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnAlterarProd;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Button btnCriarProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ComboBox cbxTamanho;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn corProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProduto;
    }
}