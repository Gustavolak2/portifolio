using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_projeto
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void TrocaImagem(object sender, EventArgs e)
        {
            Calculadora Calc = new Calculadora();

            switch ((sender as RadioButton).Name)
            {
                case "radSoma":
                    picImagem.Image = Properties.Resources.Soma;
                    lblResultado.Text = Calc.Calcular(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "+").ToString();
                    break;
                case "radSub":
                    picImagem.Image = Properties.Resources.sub;
                    lblResultado.Text = Calc.Calcular(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "-").ToString();
                    break;
                case "radMulti":
                    picImagem.Image = Properties.Resources.multi;
                    lblResultado.Text = Calc.Calcular(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "*").ToString();
                    break;
                case "radDiv":
                    picImagem.Image = Properties.Resources.div;
                    lblResultado.Text = Calc.Calcular(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "/").ToString();
                    break;
                default:
                    picImagem.Image = Properties.Resources.calculate;
                    break;
            }

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            consistencia con = new consistencia();
            con.limpar(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("finalizar?","saída",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
