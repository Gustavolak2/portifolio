using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_projeto
{
    internal class Calculadora
    {
        public double Calcular(double valor1, double valor2, string operacao) 
        {
            switch (operacao) 
            {
                case "+":
                    return valor1 + valor2;
                case "-":
                    return valor1 - valor2;
                case "*":
                    return valor1 * valor2;
                case "/":
                    return valor1 / valor2;
                default:
                    return 0;
            }
        }
    }
}
