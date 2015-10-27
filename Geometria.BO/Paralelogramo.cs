using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class Paralelogramo 
    {
        public decimal Perimetro(decimal valor1, decimal valor2)
        {
            return (valor1 + valor2) * 2;
        }
        public decimal Area(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }
    }
}
