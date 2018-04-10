using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNumeroComplexo
{
	class NumComplexo
	{
		
		// atributos

		private double re;
		private double im;

		// construtores

		public NumComplexo() // default
		{
			re = 0.0;
			im = 0.0;
		}

		public NumComplexo(double a, double b)
		{
			re = a;
			im = b;
		}

		public double modulo()
		{
			double modulo;
			modulo = Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));

			return (modulo);
		}

		public NumComplexo soma()
		{
			NumComplexo zx = new NumComplexo()
			{
				
				return zx;
			}
		}

		public double print()
		{
			Console.WriteLine("  O numero complexo z3 eh: " + ;
		}
	}
}






