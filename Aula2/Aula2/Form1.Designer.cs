namespace Aula2
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
            this.botao = new System.Windows.Forms.Button();
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.botao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Chega = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao.Location = new System.Drawing.Point(12, 12);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(311, 62);
            this.botao.TabIndex = 0;
            this.botao.Text = "Clique Aqui ";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.ForeColor = System.Drawing.Color.Red;
            this.primeiraMensagem.Location = new System.Drawing.Point(30, 77);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.Size = new System.Drawing.Size(275, 33);
            this.primeiraMensagem.TabIndex = 1;
            this.primeiraMensagem.Text = "mensagem antiga";
            this.primeiraMensagem.Click += new System.EventHandler(this.primeiraMensagem_Click);
            // 
            // botao2
            // 
            this.botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.Location = new System.Drawing.Point(15, 181);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(308, 57);
            this.botao2.TabIndex = 2;
            this.botao2.Text = "Veja Aqui";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visto Antigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Chega
            // 
            this.Chega.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chega.Location = new System.Drawing.Point(484, 12);
            this.Chega.Name = "Chega";
            this.Chega.Size = new System.Drawing.Size(304, 62);
            this.Chega.TabIndex = 4;
            this.Chega.Text = "FIM";
            this.Chega.UseVisualStyleBackColor = true;
            this.Chega.Click += new System.EventHandler(this.Chega_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(481, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "ULTIMA MENSAGEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.primeiraMensagem);
            this.Controls.Add(this.botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label primeiraMensagem;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Chega;
        private System.Windows.Forms.Label label2;
    }
}

