using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class Circulo 
    {
        public double Perimetro(double raio)
        {
            return 2 * Math.PI * raio;
        }
        public double Area(double raio)
        {
            return Math.PI * Math.Sqrt(raio);
        } 
    }
}
