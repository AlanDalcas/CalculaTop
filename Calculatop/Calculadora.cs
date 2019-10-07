using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatop
{
    class Calculadora
    {
        public string adicionaNumero(object sender)
        {
            string texto;
            Button btn = (Button)sender;
            texto = btn.Text;
            return texto;
        }

        public double somaNumero(double valor, double novoValor)
        {
            if (novoValor > 0)
            {
                valor += novoValor;
            }

            return valor;
        }

    }
}
