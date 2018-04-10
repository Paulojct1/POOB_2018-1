using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01POOB_2DVector
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector vect1 = new Vector();
			Vector vect2 = new Vector();
			Vector projecao = new Vector();

			Console.WriteLine("\n  Digite um valor para vect1(_, ): ");
			double a1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("  Digite um valor para vect1( ,_): ");
			double b1 = Convert.ToDouble(Console.ReadLine());

			vect1.setA(a1);
			vect1.setB(b1);

			Console.WriteLine("\n  Digite um valor para vect2(_, ): ");
			double a2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("  Digite um valor para vect2( ,_):");
			double b2 = Convert.ToDouble(Console.ReadLine());

			vect2.setA(a2);
			vect2.setB(b2);

			Console.WriteLine("\n  O modulo do Vector 1 é: " + vect1.modulo());
			Console.WriteLine("  O modulo do Vector 2 é: " + vect2.modulo());

			Console.WriteLine("\n  Calculando o Produto Escalar");
			Console.WriteLine("  Produto Escalar: " + vect1.prod_escalar(a2, b2) + "\n");

			Console.WriteLine("\n  Calculando o Angulo entre o Vector 1 e o Vector 2");
			Console.WriteLine("  Angulo entre Vector 1 e o Vector 2: " + vect1.angle(a2, b2));

			projecao = vect1.projecao(vect2);
			Console.WriteLine("\n  O Valor da Projeção de Vector 1 em Vector 2 eh: (" + projecao.a1 + " ; " + projecao.b1 + ").");

			Console.Read();
		}
	}
}
