using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Bemvindo a POO!");
            
            // criando um objeto da classe Retangulo

            Retangulo r1 = new Retangulo();
            double area = r1.calculaArea();
            double perimetro = r1.calculaPerimetro();
            Console.WriteLine("  Area do r1: " + area);
            Console.WriteLine("  Perimetro do r1: " + perimetro);

            //r1.setBasis(4.0);
            //r1.setHeight(5.0);

            area = r1.calculaArea();
            perimetro = r1.calculaPerimetro();

            Console.WriteLine("  Area do r1: " + area);
			Console.WriteLine("  Perimetro do r1: " + perimetro);

			Retangulo r2 = new Retangulo(7.0, 8.0);
			area = r2.calculaArea();
			perimetro = r2.calculaPerimetro();

			Console.WriteLine("  Area do r2: " + area);
			Console.WriteLine("  Perimetro do r2: " + perimetro);

			Retangulo r3 = new Retangulo("  Oi,", " tudo bem?");

			Console.Read();
        }
    }
}
