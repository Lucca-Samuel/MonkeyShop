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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(248, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(253, 43);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(290, 35);
            this.tbxNome.TabIndex = 1;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefone.Location = new System.Drawing.Point(580, 43);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(243, 35);
            this.tbxTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(574, 9);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(110, 29);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(900, 28);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(140, 50);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(621, 679);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(223, 50);
            this.btnCancelarVenda.TabIndex = 8;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
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
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(709, 156);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 35);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1019, 217);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblQtdeItens
            // 
            this.lblQtdeItens.AutoSize = true;
            this.lblQtdeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItens.Location = new System.Drawing.Point(7, 466);
            this.lblQtdeItens.Name = "lblQtdeItens";
            this.lblQtdeItens.Size = new System.Drawing.Size(129, 29);
            this.lblQtdeItens.TabIndex = 14;
            this.lblQtdeItens.Text = "Qtde Itens:";
            // 
            // tbxQtdeItens
            // 
            this.tbxQtdeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQtdeItens.Location = new System.Drawing.Point(133, 466);
            this.tbxQtdeItens.Name = "tbxQtdeItens";
            this.tbxQtdeItens.Size = new System.Drawing.Size(98, 35);
            this.tbxQtdeItens.TabIndex = 15;
            // 
            // tbxValorTotal
            // 
            this.tbxValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorTotal.Location = new System.Drawing.Point(400, 466);
            this.tbxValorTotal.Name = "tbxValorTotal";
            this.tbxValorTotal.Size = new System.Drawing.Size(134, 35);
            this.tbxValorTotal.TabIndex = 17;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(258, 466);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(136, 29);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 714);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuário:";
            // 
            // tbxCpf
            // 
            this.tbxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCpf.Location = new System.Drawing.Point(12, 43);
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(228, 35);
            this.tbxCpf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 741);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbxValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.tbxQtdeItens);
            this.Controls.Add(this.lblQtdeItens);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCodProduto);
            this.Controls.Add(this.tbxInclusao);
            this.Controls.Add(this.lblInclusao);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbxCpf);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Name = "Venda";
            this.Text = "Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbxCpf;
        private System.Windows.Forms.Label label1;
    }
}