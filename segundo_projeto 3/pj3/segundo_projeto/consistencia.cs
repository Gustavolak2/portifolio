using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_projeto
{
    internal class consistencia
    {
        public void limpar(Form frmlimpar)
        {
            foreach (Control item in frmlimpar.Controls)
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if ((item2 is TextBox))

                        {
                            (item2 as TextBox).Clear();
                            (item2 as TextBox).Focus();
                        }
                        if (item2 is Label &&
                            item2.Name == "lblResultado")
                        {
                            item2.Text = string.Empty;
                        }
                    }

                }
        }
    }
}

