
namespace ManipuladorDeStrings
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
            this.TxtEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContaP = new System.Windows.Forms.Button();
            this.ContaL = new System.Windows.Forms.Button();
            this.Maisculo = new System.Windows.Forms.Button();
            this.Minusculo = new System.Windows.Forms.Button();
            this.InverteP = new System.Windows.Forms.Button();
            this.InverteL = new System.Windows.Forms.Button();
            this.QuebraLinhas = new System.Windows.Forms.Button();
            this.EmbaralhaP = new System.Windows.Forms.Button();
            this.EmbaralhaL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEntrada
            // 
            this.TxtEntrada.Location = new System.Drawing.Point(3, 87);
            this.TxtEntrada.Multiline = true;
            this.TxtEntrada.Name = "TxtEntrada";
            this.TxtEntrada.Size = new System.Drawing.Size(400, 350);
            this.TxtEntrada.TabIndex = 0;
            this.TxtEntrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(334, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manipulador de Strings";
            // 
            // TxtSaida
            // 
            this.TxtSaida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtSaida.Location = new System.Drawing.Point(561, 87);
            this.TxtSaida.Multiline = true;
            this.TxtSaida.Name = "TxtSaida";
            this.TxtSaida.ReadOnly = true;
            this.TxtSaida.Size = new System.Drawing.Size(400, 350);
            this.TxtSaida.TabIndex = 3;
            this.TxtSaida.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(556, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // ContaP
            // 
            this.ContaP.Location = new System.Drawing.Point(432, 117);
            this.ContaP.Name = "ContaP";
            this.ContaP.Size = new System.Drawing.Size(112, 23);
            this.ContaP.TabIndex = 5;
            this.ContaP.Text = "Contar Palavras";
            this.ContaP.UseVisualStyleBackColor = true;
            this.ContaP.Click += new System.EventHandler(this.ContaP_Click);
            // 
            // ContaL
            // 
            this.ContaL.Location = new System.Drawing.Point(432, 146);
            this.ContaL.Name = "ContaL";
            this.ContaL.Size = new System.Drawing.Size(113, 23);
            this.ContaL.TabIndex = 6;
            this.ContaL.Text = "Contar Letras";
            this.ContaL.UseVisualStyleBackColor = true;
            this.ContaL.Click += new System.EventHandler(this.ContaL_Click);
            // 
            // Maisculo
            // 
            this.Maisculo.Location = new System.Drawing.Point(432, 176);
            this.Maisculo.Name = "Maisculo";
            this.Maisculo.Size = new System.Drawing.Size(112, 23);
            this.Maisculo.TabIndex = 7;
            this.Maisculo.Text = "Maiusculo";
            this.Maisculo.UseVisualStyleBackColor = true;
            this.Maisculo.Click += new System.EventHandler(this.Maisculo_Click);
            // 
            // Minusculo
            // 
            this.Minusculo.Location = new System.Drawing.Point(432, 206);
            this.Minusculo.Name = "Minusculo";
            this.Minusculo.Size = new System.Drawing.Size(112, 23);
            this.Minusculo.TabIndex = 8;
            this.Minusculo.Text = "Minusculo";
            this.Minusculo.UseVisualStyleBackColor = true;
            this.Minusculo.Click += new System.EventHandler(this.Minusculo_Click);
            // 
            // InverteP
            // 
            this.InverteP.Location = new System.Drawing.Point(432, 236);
            this.InverteP.Name = "InverteP";
            this.InverteP.Size = new System.Drawing.Size(112, 23);
            this.InverteP.TabIndex = 9;
            this.InverteP.Text = "Inverte Palavra";
            this.InverteP.UseVisualStyleBackColor = true;
            this.InverteP.Click += new System.EventHandler(this.InvertePalavra_Click);
            // 
            // InverteL
            // 
            this.InverteL.Location = new System.Drawing.Point(432, 266);
            this.InverteL.Name = "InverteL";
            this.InverteL.Size = new System.Drawing.Size(112, 23);
            this.InverteL.TabIndex = 10;
            this.InverteL.Text = "Inverte Letras";
            this.InverteL.UseVisualStyleBackColor = true;
            this.InverteL.Click += new System.EventHandler(this.InverteLetra_Click);
            // 
            // QuebraLinhas
            // 
            this.QuebraLinhas.Location = new System.Drawing.Point(432, 295);
            this.QuebraLinhas.Name = "QuebraLinhas";
            this.QuebraLinhas.Size = new System.Drawing.Size(112, 23);
            this.QuebraLinhas.TabIndex = 11;
            this.QuebraLinhas.Text = "Quebra de Linhas";
            this.QuebraLinhas.UseVisualStyleBackColor = true;
            this.QuebraLinhas.Click += new System.EventHandler(this.QuebraLinhas_Click);
            // 
            // EmbaralhaP
            // 
            this.EmbaralhaP.Location = new System.Drawing.Point(432, 325);
            this.EmbaralhaP.Name = "EmbaralhaP";
            this.EmbaralhaP.Size = new System.Drawing.Size(112, 23);
            this.EmbaralhaP.TabIndex = 12;
            this.EmbaralhaP.Text = "Embaralha Palavras";
            this.EmbaralhaP.UseVisualStyleBackColor = true;
            this.EmbaralhaP.Click += new System.EventHandler(this.EmbaralhaP_Click);
            // 
            // EmbaralhaL
            // 
            this.EmbaralhaL.Location = new System.Drawing.Point(432, 355);
            this.EmbaralhaL.Name = "EmbaralhaL";
            this.EmbaralhaL.Size = new System.Drawing.Size(112, 23);
            this.EmbaralhaL.TabIndex = 13;
            this.EmbaralhaL.Text = "Embaralha Letras";
            this.EmbaralhaL.UseVisualStyleBackColor = true;
            this.EmbaralhaL.Click += new System.EventHandler(this.EmbaralhaL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Escolha uma operação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Digite algum texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmbaralhaL);
            this.Controls.Add(this.EmbaralhaP);
            this.Controls.Add(this.QuebraLinhas);
            this.Controls.Add(this.InverteL);
            this.Controls.Add(this.InverteP);
            this.Controls.Add(this.Minusculo);
            this.Controls.Add(this.Maisculo);
            this.Controls.Add(this.ContaL);
            this.Controls.Add(this.ContaP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ContaP;
        private System.Windows.Forms.Button ContaL;
        private System.Windows.Forms.Button Maisculo;
        private System.Windows.Forms.Button Minusculo;
        private System.Windows.Forms.Button InverteP;
        private System.Windows.Forms.Button InverteL;
        private System.Windows.Forms.Button QuebraLinhas;
        private System.Windows.Forms.Button EmbaralhaP;
        private System.Windows.Forms.Button EmbaralhaL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

