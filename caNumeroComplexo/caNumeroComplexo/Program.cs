using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNumeroComplexo
{
	class Program
	{
		static void Main(string[] args)
		{

			NumComplexo z1 = new NumComplexo(3.0, 4.0);

			Console.WriteLine("  O modulo do r1 eh: " + r1.modulo());

			NumComplexo z2 = new NumComplexo(5.7, 6.8);
			NumComplexo z3 = new NumComplexo();

			z3 = z1.soma(z2);

			z3.print();

			Console.Read();
		}
	}
}
