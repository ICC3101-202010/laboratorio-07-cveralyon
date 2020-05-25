using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLAB7
{
    class suma
    {
        public static List<string> historial = new List<string>();

        public double Sumar(double numero1, double numero2)
        {
            double suma;
            suma = numero1 + numero2;
            return suma;
        }
    }
}
