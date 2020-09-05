namespace Aula01Chacara
{
    partial class Inicial
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.rbPortugues = new System.Windows.Forms.RadioButton();
            this.rbIngles = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(62, 73);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(280, 29);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Digite uma mensagem:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(67, 268);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 31);
            this.lblResult.TabIndex = 1;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(67, 119);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(275, 22);
            this.txtMensagem.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(432, 80);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 44);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cmbCores
            // 
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Items.AddRange(new object[] {
            "Selecione uma cor",
            "Amarela",
            "Azul",
            "Vermelho",
            "Verde",
            "Branco",
            "Preto"});
            this.cmbCores.Location = new System.Drawing.Point(67, 163);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(275, 24);
            this.cmbCores.TabIndex = 4;
            // 
            // rbPortugues
            // 
            this.rbPortugues.AutoSize = true;
            this.rbPortugues.Location = new System.Drawing.Point(131, 210);
            this.rbPortugues.Name = "rbPortugues";
            this.rbPortugues.Size = new System.Drawing.Size(94, 21);
            this.rbPortugues.TabIndex = 5;
            this.rbPortugues.TabStop = true;
            this.rbPortugues.Text = "Português";
            this.rbPortugues.UseVisualStyleBackColor = true;
            // 
            // rbIngles
            // 
            this.rbIngles.AutoSize = true;
            this.rbIngles.Location = new System.Drawing.Point(267, 210);
            this.rbIngles.Name = "rbIngles";
            this.rbIngles.Size = new System.Drawing.Size(66, 21);
            this.rbIngles.TabIndex = 6;
            this.rbIngles.TabStop = true;
            this.rbIngles.Text = "Inglês";
            this.rbIngles.UseVisualStyleBackColor = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.rbIngles);
            this.Controls.Add(this.rbPortugues);
            this.Controls.Add(this.cmbCores);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMensagem);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Mensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cmbCores;
        private System.Windows.Forms.RadioButton rbPortugues;
        private System.Windows.Forms.RadioButton rbIngles;
    }
}

