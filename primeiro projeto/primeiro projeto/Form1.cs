
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro_projeto
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnsair_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty; txt2.Text = "";txtresultado.Clear
                ();lblresultado.Text = string.Empty;
        }


        private void btncalcular_Click_1(object sender, EventArgs e)
        {//entrada de dados
             if (txt1.Text != string.Empty && txt2.Text != string.Empty)
            {
                int num1, num2, resultado;
                num1 = Convert.ToInt32(txt2.Text);
                num2 = int.Parse(txt1.Text);
                resultado = (num1 + num2) * num2;
                //saida de dados
                lblresultado.Text = "resultado é:" + resultado.ToString();
                txtresultado.Text = "O resultado é: " + resultado.ToString();
                //saída atraves de uma caixa de dialogo
                MessageBox.Show("resultado é: " + resultado, "resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("finalizar?", "saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
