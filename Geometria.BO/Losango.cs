using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class Losango 
    {
        public decimal Perimetro(decimal valor)
        {
            return valor * 4;
        }
        public decimal Area(decimal diagonal1, decimal diagonal2)
        {
            return (diagonal1 * diagonal2) / 2;
        }
    }
}
