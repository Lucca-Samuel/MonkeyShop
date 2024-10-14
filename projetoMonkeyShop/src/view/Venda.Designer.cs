namespace projetoMonkeyShop.src.view
{
    partial class Venda
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
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.lblInclusao = new System.Windows.Forms.Label();
            this.tbxInclusao = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblQtdeItens = new System.Windows.Forms.Label();
            this.tbxQtdeItens = new System.Windows.Forms.TextBox();
            this.tbxValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.tbxCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDesconto = new System.Windows.Forms.TextBox();
            this.gbxInfos = new System.Windows.Forms.GroupBox();
            this.tbxValorFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFormPgto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(179, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(184, 43);
            this.tbxNome.Multiline = true;
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(220, 25);
            this.tbxNome.TabIndex = 1;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefone.Location = new System.Drawing.Point(423, 43);
            this.tbxTelefone.Multiline = true;
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(173, 25);
            this.tbxTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(417, 9);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(96, 25);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(626, 33);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(140, 35);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(397, 682);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(223, 50);
            this.btnCancelarVenda.TabIndex = 8;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // lblInclusao
            // 
            this.lblInclusao.AutoSize = true;
            this.lblInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclusao.Location = new System.Drawing.Point(8, 110);
            this.lblInclusao.Name = "lblInclusao";
            this.lblInclusao.Size = new System.Drawing.Size(128, 16);
            this.lblInclusao.TabIndex = 9;
            this.lblInclusao.Text = "Inclusão no Carrinho";
            // 
            // tbxInclusao
            // 
            this.tbxInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInclusao.Location = new System.Drawing.Point(12, 156);
            this.tbxInclusao.Name = "tbxInclusao";
            this.tbxInclusao.Size = new System.Drawing.Size(676, 35);
            this.tbxInclusao.TabIndex = 10;
            this.tbxInclusao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInclusao_KeyDown);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(8, 129);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(116, 24);
            this.lblCodProduto.TabIndex = 11;
            this.lblCodProduto.Text = "Cod Produto";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(709, 156);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 35);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Adicionar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 217);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblQtdeItens
            // 
            this.lblQtdeItens.AutoSize = true;
            this.lblQtdeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItens.Location = new System.Drawing.Point(280, 25);
            this.lblQtdeItens.Name = "lblQtdeItens";
            this.lblQtdeItens.Size = new System.Drawing.Size(116, 25);
            this.lblQtdeItens.TabIndex = 14;
            this.lblQtdeItens.Text = "Qtde Itens:";
            // 
            // tbxQtdeItens
            // 
            this.tbxQtdeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQtdeItens.Location = new System.Drawing.Point(415, 25);
            this.tbxQtdeItens.Multiline = true;
            this.tbxQtdeItens.Name = "tbxQtdeItens";
            this.tbxQtdeItens.Size = new System.Drawing.Size(134, 25);
            this.tbxQtdeItens.TabIndex = 15;
            // 
            // tbxValorTotal
            // 
            this.tbxValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorTotal.Location = new System.Drawing.Point(415, 63);
            this.tbxValorTotal.Multiline = true;
            this.tbxValorTotal.Name = "tbxValorTotal";
            this.tbxValorTotal.Size = new System.Drawing.Size(134, 25);
            this.tbxValorTotal.TabIndex = 17;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(280, 63);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(104, 25);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "SubTotal:";
            // 
            // tbxCpf
            // 
            this.tbxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCpf.Location = new System.Drawing.Point(12, 43);
            this.tbxCpf.Multiline = true;
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(150, 25);
            this.tbxCpf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Desconto";
            // 
            // tbxDesconto
            // 
            this.tbxDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesconto.Location = new System.Drawing.Point(695, 25);
            this.tbxDesconto.Multiline = true;
            this.tbxDesconto.Name = "tbxDesconto";
            this.tbxDesconto.Size = new System.Drawing.Size(134, 25);
            this.tbxDesconto.TabIndex = 17;
            // 
            // gbxInfos
            // 
            this.gbxInfos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxInfos.Controls.Add(this.cbxFormPgto);
            this.gbxInfos.Controls.Add(this.tbxDesconto);
            this.gbxInfos.Controls.Add(this.label2);
            this.gbxInfos.Controls.Add(this.tbxValorTotal);
            this.gbxInfos.Controls.Add(this.lblValorTotal);
            this.gbxInfos.Controls.Add(this.tbxValorFinal);
            this.gbxInfos.Controls.Add(this.lblQtdeItens);
            this.gbxInfos.Controls.Add(this.label3);
            this.gbxInfos.Controls.Add(this.tbxQtdeItens);
            this.gbxInfos.Location = new System.Drawing.Point(8, 441);
            this.gbxInfos.Name = "gbxInfos";
            this.gbxInfos.Size = new System.Drawing.Size(841, 107);
            this.gbxInfos.TabIndex = 19;
            this.gbxInfos.TabStop = false;
            this.gbxInfos.Text = "Informações da Compra";
            // 
            // tbxValorFinal
            // 
            this.tbxValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorFinal.Location = new System.Drawing.Point(695, 63);
            this.tbxValorFinal.Multiline = true;
            this.tbxValorFinal.Name = "tbxValorFinal";
            this.tbxValorFinal.Size = new System.Drawing.Size(134, 25);
            this.tbxValorFinal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor Total:";
            // 
            // cbxFormPgto
            // 
            this.cbxFormPgto.FormattingEnabled = true;
            this.cbxFormPgto.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Débito",
            "Crédito a vista",
            "Crédito parcelado"});
            this.cbxFormPgto.Location = new System.Drawing.Point(7, 29);
            this.cbxFormPgto.Name = "cbxFormPgto";
            this.cbxFormPgto.Size = new System.Drawing.Size(190, 21);
            this.cbxFormPgto.TabIndex = 18;
            this.cbxFormPgto.Text = "Selecione a Forma de Pagamento";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(626, 682);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(223, 50);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 741);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCodProduto);
            this.Controls.Add(this.tbxInclusao);
            this.Controls.Add(this.lblInclusao);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbxCpf);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbxInfos);
            this.Name = "Venda";
            this.Text = "Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxInfos.ResumeLayout(false);
            this.gbxInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Label lblInclusao;
        private System.Windows.Forms.TextBox tbxInclusao;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblQtdeItens;
        private System.Windows.Forms.TextBox tbxQtdeItens;
        private System.Windows.Forms.TextBox tbxValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox tbxCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDesconto;
        private System.Windows.Forms.GroupBox gbxInfos;
        private System.Windows.Forms.TextBox tbxValorFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFormPgto;
        private System.Windows.Forms.Button btnFinalizar;
    }
}