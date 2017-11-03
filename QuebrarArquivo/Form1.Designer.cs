namespace QuebrarArquivo
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtArquivosQuebrados = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionaArquivo = new System.Windows.Forms.Button();
            this.btnSelecionaDiretorio = new System.Windows.Forms.Button();
            this.lstProgresso = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdLinhas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Processar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArquivosQuebrados
            // 
            this.txtArquivosQuebrados.Location = new System.Drawing.Point(12, 83);
            this.txtArquivosQuebrados.Name = "txtArquivosQuebrados";
            this.txtArquivosQuebrados.Size = new System.Drawing.Size(326, 20);
            this.txtArquivosQuebrados.TabIndex = 1;
            this.txtArquivosQuebrados.TextChanged += new System.EventHandler(this.txtArquivosQuebrados_TextChanged);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(12, 36);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(326, 20);
            this.txtArquivo.TabIndex = 2;
            this.txtArquivo.TextChanged += new System.EventHandler(this.txtArquivo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha o arquivo para ser quebrado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escolha o local dos arquivos quebrados";
            // 
            // btnSelecionaArquivo
            // 
            this.btnSelecionaArquivo.Location = new System.Drawing.Point(344, 34);
            this.btnSelecionaArquivo.Name = "btnSelecionaArquivo";
            this.btnSelecionaArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaArquivo.TabIndex = 5;
            this.btnSelecionaArquivo.Text = "Procurar";
            this.btnSelecionaArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionaArquivo.Click += new System.EventHandler(this.btnSelecionaArquivo_Click);
            // 
            // btnSelecionaDiretorio
            // 
            this.btnSelecionaDiretorio.Location = new System.Drawing.Point(344, 81);
            this.btnSelecionaDiretorio.Name = "btnSelecionaDiretorio";
            this.btnSelecionaDiretorio.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaDiretorio.TabIndex = 6;
            this.btnSelecionaDiretorio.Text = "Procurar";
            this.btnSelecionaDiretorio.UseVisualStyleBackColor = true;
            this.btnSelecionaDiretorio.Click += new System.EventHandler(this.btnSelecionaDiretorio_Click);
            // 
            // lstProgresso
            // 
            this.lstProgresso.FormattingEnabled = true;
            this.lstProgresso.Location = new System.Drawing.Point(12, 157);
            this.lstProgresso.Name = "lstProgresso";
            this.lstProgresso.Size = new System.Drawing.Size(407, 121);
            this.lstProgresso.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qtd. Linhas";
            // 
            // txtQtdLinhas
            // 
            this.txtQtdLinhas.Location = new System.Drawing.Point(12, 128);
            this.txtQtdLinhas.Name = "txtQtdLinhas";
            this.txtQtdLinhas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdLinhas.TabIndex = 9;
            this.txtQtdLinhas.TextChanged += new System.EventHandler(this.txtQtdLinhas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 319);
            this.Controls.Add(this.txtQtdLinhas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstProgresso);
            this.Controls.Add(this.btnSelecionaDiretorio);
            this.Controls.Add(this.btnSelecionaArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.txtArquivosQuebrados);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Quebrar Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArquivosQuebrados;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecionaArquivo;
        private System.Windows.Forms.Button btnSelecionaDiretorio;
        private System.Windows.Forms.ListBox lstProgresso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdLinhas;
    }
}

