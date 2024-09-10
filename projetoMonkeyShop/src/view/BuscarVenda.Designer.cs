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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVisualizarVenda = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.rbtnCsv = new System.Windows.Forms.RadioButton();
            this.rbtnXlsx = new System.Windows.Forms.RadioButton();
            this.rbtnPdf = new System.Windows.Forms.RadioButton();
            this.colCodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscarVenda
            // 
            this.tbxBuscarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarVenda.Location = new System.Drawing.Point(22, 50);
            this.tbxBuscarVenda.Name = "tbxBuscarVenda";
            this.tbxBuscarVenda.Size = new System.Drawing.Size(822, 35);
            this.tbxBuscarVenda.TabIndex = 3;
            // 
            // lblBuscarVenda
            // 
            this.lblBuscarVenda.AutoSize = true;
            this.lblBuscarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarVenda.Location = new System.Drawing.Point(16, 16);
            this.lblBuscarVenda.Name = "lblBuscarVenda";
            this.lblBuscarVenda.Size = new System.Drawing.Size(162, 29);
            this.lblBuscarVenda.TabIndex = 2;
            this.lblBuscarVenda.Text = "Buscar Venda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(873, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodVenda,
            this.colData,
            this.colCliente,
            this.colValor});
            this.dataGridView1.Location = new System.Drawing.Point(21, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnVisualizarVenda
            // 
            this.btnVisualizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarVenda.Location = new System.Drawing.Point(21, 286);
            this.btnVisualizarVenda.Name = "btnVisualizarVenda";
            this.btnVisualizarVenda.Size = new System.Drawing.Size(264, 50);
            this.btnVisualizarVenda.TabIndex = 7;
            this.btnVisualizarVenda.Text = "Visualizar Venda";
            this.btnVisualizarVenda.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(21, 351);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(264, 50);
            this.btnGerarRelatorio.TabIndex = 8;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // rbtnCsv
            // 
            this.rbtnCsv.AutoSize = true;
            this.rbtnCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCsv.Location = new System.Drawing.Point(22, 407);
            this.rbtnCsv.Name = "rbtnCsv";
            this.rbtnCsv.Size = new System.Drawing.Size(71, 28);
            this.rbtnCsv.TabIndex = 9;
            this.rbtnCsv.TabStop = true;
            this.rbtnCsv.Text = ".CSV";
            this.rbtnCsv.UseVisualStyleBackColor = true;
            // 
            // rbtnXlsx
            // 
            this.rbtnXlsx.AutoSize = true;
            this.rbtnXlsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnXlsx.Location = new System.Drawing.Point(99, 407);
            this.rbtnXlsx.Name = "rbtnXlsx";
            this.rbtnXlsx.Size = new System.Drawing.Size(83, 28);
            this.rbtnXlsx.TabIndex = 10;
            this.rbtnXlsx.TabStop = true;
            this.rbtnXlsx.Text = ".XLSX";
            this.rbtnXlsx.UseVisualStyleBackColor = true;
            // 
            // rbtnPdf
            // 
            this.rbtnPdf.AutoSize = true;
            this.rbtnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPdf.Location = new System.Drawing.Point(198, 407);
            this.rbtnPdf.Name = "rbtnPdf";
            this.rbtnPdf.Size = new System.Drawing.Size(70, 28);
            this.rbtnPdf.TabIndex = 11;
            this.rbtnPdf.TabStop = true;
            this.rbtnPdf.Text = ".PDF";
            this.rbtnPdf.UseVisualStyleBackColor = true;
            // 
            // colCodVenda
            // 
            this.colCodVenda.HeaderText = "Cód Venda";
            this.colCodVenda.Name = "colCodVenda";
            this.colCodVenda.Width = 200;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.Width = 200;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 200;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 200;
            // 
            // BuscarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 741);
            this.Controls.Add(this.rbtnPdf);
            this.Controls.Add(this.rbtnXlsx);
            this.Controls.Add(this.rbtnCsv);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnVisualizarVenda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxBuscarVenda);
            this.Controls.Add(this.lblBuscarVenda);
            this.Name = "BuscarVenda";
            this.Text = "BuscarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBuscarVenda;
        private System.Windows.Forms.Label lblBuscarVenda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVisualizarVenda;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.RadioButton rbtnCsv;
        private System.Windows.Forms.RadioButton rbtnXlsx;
        private System.Windows.Forms.RadioButton rbtnPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}