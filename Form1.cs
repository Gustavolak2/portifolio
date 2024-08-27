using System;
using System.Windows.Forms;

namespace segundo_projeto
{
    public partial class frmCalculadora : Form
    {
        private const string V = "radSub";

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void TrocaImagem(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "radSoma":
                    picImagem.Image = Properties.Resources.Soma;
                    break; Calculadora calc = new Calculadora();

                case "radSub":
                    picImagem.Image = Properties.Resources.sub;
                    lblResultado.Text = calc.Calcular()
                    break;
                case "radMulti":
                    picImagem.Image = Properties.Resources.multi;
                    lblResultado.par
              double.tetxtNum2.Text); "*";.ToString();
                    picImagem.Image = Properties.Resources.multi;
                    break;
                case "radDiv":
                    lblResultado.Parse = calc.Calcular(double.Parse(txtNum1.Text),
              double.Parse(txtNum2.Text), "*"); ToString();
                    picImagem.Image = Properties.Resources.div;
                    break;
                default:
                    picImagem.Image = Properties.Resources.calculate;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}