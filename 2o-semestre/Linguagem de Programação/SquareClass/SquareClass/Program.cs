using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Square obj = new Square();

            obj.saudacao();

            Console.WriteLine("\nInforme o comprimento do lado do quadrado que deseja criar:");
            double valorlado = Convert.ToDouble(Console.ReadLine());

            double perimetro = obj.perimetro(valorlado);
            double area = obj.area(valorlado);

            Console.WriteLine("\nConsiderando o tamanho informado, seu quadrado terá um valor de perímetro (soma dos lados) de " + perimetro + ", e a área total de " + area +".");
            Console.ReadKey();
        }
    }
}
