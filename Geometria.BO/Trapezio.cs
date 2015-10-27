using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class Trapezio 
    {
        public decimal Perimetro(decimal valor1, decimal valor2, decimal diagonal1, decimal diagonal2)
        {
            return valor1 + valor2 + diagonal1 + diagonal2;
        }
        public decimal Area(decimal valor1, decimal valor2, decimal valor3)
        {
            return ((valor1 + valor2) * valor3) / 2;
        }
    }
}
