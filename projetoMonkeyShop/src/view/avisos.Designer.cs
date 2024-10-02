namespace projetoMonkeyShop.src.view
{
    partial class avisos
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
            this.lblMensagens = new System.Windows.Forms.Label();
            this.btnNovaMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagens.Location = new System.Drawing.Point(28, 21);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(138, 29);
            this.lblMensagens.TabIndex = 0;
            this.lblMensagens.Text = "Mensagens";
            // 
            // btnNovaMsg
            // 
            this.btnNovaMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMsg.Location = new System.Drawing.Point(33, 362);
            this.btnNovaMsg.Name = "btnNovaMsg";
            this.btnNovaMsg.Size = new System.Drawing.Size(222, 55);
            this.btnNovaMsg.TabIndex = 1;
            this.btnNovaMsg.Text = "Nova Mensagem";
            this.btnNovaMsg.UseVisualStyleBackColor = true;
            // 
            // avisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 741);
            this.Controls.Add(this.btnNovaMsg);
            this.Controls.Add(this.lblMensagens);
            this.Name = "avisos";
            this.Text = "avisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagens;
        private System.Windows.Forms.Button btnNovaMsg;
    }
}