namespace WindowsFormsApp2
{
    partial class Form1
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
            this.calcular = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.situacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(27, 137);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(120, 137);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 1;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe a 1ª nota";
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(151, 56);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(100, 20);
            this.valor2.TabIndex = 3;
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(151, 30);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 20);
            this.valor1.TabIndex = 4;
            this.valor1.TextChanged += new System.EventHandler(this.valor1_TextChanged);
            // 
            // valor3
            // 
            this.valor3.Location = new System.Drawing.Point(151, 82);
            this.valor3.Name = "valor3";
            this.valor3.Size = new System.Drawing.Size(100, 20);
            this.valor3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Informe a 2ª nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informe a 3ª nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Média do Aluno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Situação do Aluno:";
            // 
            // media
            // 
            this.media.AutoSize = true;
            this.media.Location = new System.Drawing.Point(390, 137);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(13, 13);
            this.media.TabIndex = 10;
            this.media.Text = "0";
            // 
            // situacao
            // 
            this.situacao.AutoSize = true;
            this.situacao.Location = new System.Drawing.Point(390, 159);
            this.situacao.Name = "situacao";
            this.situacao.Size = new System.Drawing.Size(10, 13);
            this.situacao.TabIndex = 11;
            this.situacao.Text = "-";
            this.situacao.Click += new System.EventHandler(this.situacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 215);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.media);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor3);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.Label situacao;
    }
}

