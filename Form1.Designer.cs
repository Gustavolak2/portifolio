namespace segundo_projeto
{
    partial class frmCalculadora
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
            this.grpDadosEntrada = new System.Windows.Forms.GroupBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.grpOperacao = new System.Windows.Forms.GroupBox();
            this.radDiv = new System.Windows.Forms.RadioButton();
            this.radMulti = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radSoma = new System.Windows.Forms.RadioButton();
            this.grpNum3 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.grpDadosEntrada.SuspendLayout();
            this.grpOperacao.SuspendLayout();
            this.grpNum3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosEntrada
            // 
            this.grpDadosEntrada.Controls.Add(this.txtNum2);
            this.grpDadosEntrada.Controls.Add(this.txtNum1);
            this.grpDadosEntrada.Controls.Add(this.lblNum2);
            this.grpDadosEntrada.Controls.Add(this.lblNum1);
            this.grpDadosEntrada.Location = new System.Drawing.Point(12, 12);
            this.grpDadosEntrada.Name = "grpDadosEntrada";
            this.grpDadosEntrada.Size = new System.Drawing.Size(310, 144);
            this.grpDadosEntrada.TabIndex = 0;
            this.grpDadosEntrada.TabStop = false;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(9, 99);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(9, 32);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(6, 83);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(128, 13);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Digite o segundo numero:";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(6, 16);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(123, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Digite o primeiro numero:";
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.radDiv);
            this.grpOperacao.Controls.Add(this.radMulti);
            this.grpOperacao.Controls.Add(this.radSub);
            this.grpOperacao.Controls.Add(this.radSoma);
            this.grpOperacao.Location = new System.Drawing.Point(400, 12);
            this.grpOperacao.Name = "grpOperacao";
            this.grpOperacao.Size = new System.Drawing.Size(256, 144);
            this.grpOperacao.TabIndex = 1;
            this.grpOperacao.TabStop = false;
            this.grpOperacao.Text = "Escolha a operação:";
            // 
            // radDiv
            // 
            this.radDiv.AutoSize = true;
            this.radDiv.Location = new System.Drawing.Point(10, 106);
            this.radDiv.Name = "radDiv";
            this.radDiv.Size = new System.Drawing.Size(60, 17);
            this.radDiv.TabIndex = 3;
            this.radDiv.TabStop = true;
            this.radDiv.Text = "Divisão";
            this.radDiv.UseVisualStyleBackColor = true;
            this.radDiv.CheckedChanged += new System.EventHandler(this.TrocaImagem);
            // 
            // radMulti
            // 
            this.radMulti.AutoSize = true;
            this.radMulti.Location = new System.Drawing.Point(10, 83);
            this.radMulti.Name = "radMulti";
            this.radMulti.Size = new System.Drawing.Size(87, 17);
            this.radMulti.TabIndex = 2;
            this.radMulti.TabStop = true;
            this.radMulti.Text = "Multiplicação";
            this.radMulti.UseVisualStyleBackColor = true;
            this.radMulti.CheckedChanged += new System.EventHandler(this.TrocaImagem);
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Location = new System.Drawing.Point(10, 60);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(74, 17);
            this.radSub.TabIndex = 1;
            this.radSub.TabStop = true;
            this.radSub.Text = "Subtração";
            this.radSub.UseVisualStyleBackColor = true;
            this.radSub.CheckedChanged += new System.EventHandler(this.TrocaImagem);
            // 
            // radSoma
            // 
            this.radSoma.AutoSize = true;
            this.radSoma.Location = new System.Drawing.Point(10, 32);
            this.radSoma.Name = "radSoma";
            this.radSoma.Size = new System.Drawing.Size(52, 17);
            this.radSoma.TabIndex = 0;
            this.radSoma.TabStop = true;
            this.radSoma.Text = "Soma";
            this.radSoma.UseVisualStyleBackColor = true;
            this.radSoma.CheckedChanged += new System.EventHandler(this.TrocaImagem);
            // 
            // grpNum3
            // 
            this.grpNum3.Controls.Add(this.lblResultado);
            this.grpNum3.Controls.Add(this.lblTexto);
            this.grpNum3.Location = new System.Drawing.Point(12, 201);
            this.grpNum3.Name = "grpNum3";
            this.grpNum3.Size = new System.Drawing.Size(310, 195);
            this.grpNum3.TabIndex = 3;
            this.grpNum3.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(134, 101);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(70, 31);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(153, 13);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "RESULTADO DA OPERAÇÃO";
            // 
            // picImagem
            // 
            this.picImagem.Image = global::segundo_projeto.Properties.Resources.calculate;
            this.picImagem.Location = new System.Drawing.Point(486, 201);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(170, 195);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 2;
            this.picImagem.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(70, 403);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "&Limpar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.UseWaitCursor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(182, 403);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 35);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "&Sair";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.grpNum3);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grpOperacao);
            this.Controls.Add(this.grpDadosEntrada);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora simples";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.grpDadosEntrada.ResumeLayout(false);
            this.grpDadosEntrada.PerformLayout();
            this.grpOperacao.ResumeLayout(false);
            this.grpOperacao.PerformLayout();
            this.grpNum3.ResumeLayout(false);
            this.grpNum3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosEntrada;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.GroupBox grpOperacao;
        private System.Windows.Forms.RadioButton radDiv;
        private System.Windows.Forms.RadioButton radMulti;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radSoma;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox grpNum3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

