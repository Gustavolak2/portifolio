namespace primeiro_projeto
{
    partial class frm1
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
            this.components = new System.ComponentModel.Container();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(583, 54);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(169, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "digite um primeiro numero";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(583, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(155, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "digite o segundo numero";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(586, 140);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(152, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(586, 73);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(152, 20);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Image = global::primeiro_projeto.Properties.Resources.hand_point;
            this.btncalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncalcular.Location = new System.Drawing.Point(545, 167);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 48);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "&calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click_1);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(626, 167);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 46);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "&limpar";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfinalizar.Location = new System.Drawing.Point(707, 168);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(75, 46);
            this.btnfinalizar.TabIndex = 6;
            this.btnfinalizar.Text = "&finalizar";
            this.toolTip1.SetToolTip(this.btnfinalizar, "fecha o aplicativo");
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(542, 269);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(73, 41);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "resultado:";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtresultado.Location = new System.Drawing.Point(610, 269);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 8;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 585);
            this.ControlBox = false;
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Name = "frm1";
            this.Text = "primeiro teste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

