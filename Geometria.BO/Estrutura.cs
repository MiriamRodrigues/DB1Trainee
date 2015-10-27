using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class Estrutura
    {
        public static void Programa()
        {

            byte escolha1 = 0;


            do
            {
                Console.WriteLine("Escolha o numero referente a forma geometrica desejada:");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("1-Triângulo Equilatero");
                Console.WriteLine("2-Quadrado");
                Console.WriteLine("3-Retângulo");
                Console.WriteLine("4-Círculo");
                Console.WriteLine("5-Losango");
                Console.WriteLine("6-Paralelogramo");
                Console.WriteLine("7-Trápezio");
                Console.WriteLine("---------------------------------------------------------------------------");
                byte escolha = byte.Parse(Console.ReadLine());
                Console.Clear();
                if (escolha == 1)
                {   //Entrada
                    Console.WriteLine("Você escolheu o triângulo equilatero!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o tamanho de um dos lados do triângulo: ");
                    decimal lado = decimal.Parse(Console.ReadLine());
                    TrianguloEqui triangulo = new TrianguloEqui();


                    //Saída
                    Console.WriteLine("A área é: " + triangulo.Area(lado));
                    Console.WriteLine("O perimetro é: " + triangulo.Perimetro(lado));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                if (escolha == 2)
                {   //Entrada
                    Console.WriteLine("Você escolheu o quadrado!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o tamanho de um dos lados do quadrado: ");
                    decimal lado = decimal.Parse(Console.ReadLine());
                    Quadrado quadrado = new Quadrado();

                    //Saída
                    Console.WriteLine("A área é: " + quadrado.Area(lado));
                    Console.WriteLine("O perimetro é: " + quadrado.Perimetro(lado));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                if (escolha == 3)
                {   //Entrada
                    Console.WriteLine("Você escolheu o retângulo!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o comprimento de um dos lados do retângulo: ");
                    decimal lado1 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe a altura de um dos lados do retângulo: ");
                    decimal lado2 = decimal.Parse(Console.ReadLine());
                    Retangulo retangulo = new Retangulo();

                    //Saída
                    Console.WriteLine("A área é: " + retangulo.Area(lado1, lado2));
                    Console.WriteLine("O perimetro é: " + retangulo.Perimetro(lado1, lado2));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                if (escolha == 4)
                {   //Entrada
                    Console.WriteLine("Você escolheu o círculo!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o tamanho do raio do círculo: ");
                    double raio = double.Parse(Console.ReadLine());
                    Circulo circulo = new Circulo();

                    //Saída
                    Console.WriteLine("A área é: " + circulo.Area(raio));
                    Console.WriteLine("O perimetro é: " + circulo.Perimetro(raio));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                if (escolha == 5)
                {   //Entrada
                    Console.WriteLine("Você escolheu o losango!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o tamanho da primeira diágonal do losango: ");
                    decimal lado1 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe o tamanho da segunda diágonal do losango: ");
                    decimal lado2 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe o tamanho de um dos lados do losango: ");
                    decimal lado3 = decimal.Parse(Console.ReadLine());
                    Losango losango = new Losango();

                    //Saída
                    Console.WriteLine("A área é: " + losango.Area(lado1, lado2));
                    Console.WriteLine("O perimetro é: " + losango.Perimetro(lado3));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                if (escolha == 6)
                {   //Entrada
                    Console.WriteLine("Você escolheu o paralelogramo!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o comprimento de um dos lados do paralelogramo: ");
                    decimal lado1 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe a altura de um dos lados do paralelogramo: ");
                    decimal lado2 = decimal.Parse(Console.ReadLine());
                    Paralelogramo paralelogramo = new Paralelogramo();

                    //Saída
                    Console.WriteLine("A área é: " + paralelogramo.Area(lado1, lado2));
                    Console.WriteLine("O perimetro é: " + paralelogramo.Perimetro(lado1, lado2));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                if (escolha == 7)
                {   //Entrada
                    Console.WriteLine("Você escolheu o trapézio!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Informe o tamanho da base menor do trapézio: ");
                    decimal lado1 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe o tamanho da base maior do trapézio: ");
                    decimal lado2 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe o tamanho da altura do trapézio: ");
                    decimal lado3 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe o tamanho da primeira diágonal do trapézio: ");
                    decimal diagonal1 = decimal.Parse(Console.ReadLine());
                    Console.Write("Informe o tamanho da segunda diágonal do trapézio: ");
                    decimal diagonal2 = decimal.Parse(Console.ReadLine());
                    Trapezio trapezio = new Trapezio();

                    //Saída
                    Console.WriteLine("A área é: " + trapezio.Area(lado1, lado2, lado3));
                    Console.WriteLine("O perimetro é: " + trapezio.Perimetro(lado1, lado2, diagonal1, diagonal2));
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                
                
            } while (escolha1 != 8);

        }
    }
}
