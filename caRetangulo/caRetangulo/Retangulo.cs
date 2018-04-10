using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Retangulo
    {
        // atributos

        private double basis;
        private double height;

        // metodos

		//// construtores de classe 

		public Retangulo()
		{
			basis = 4.0;
			height = 5.0;
		}

		public Retangulo(double b, double h)
		{
			basis = b;
			height = h;
		}

		public Retangulo(String a, String b)
		{
			Console.WriteLine(a + b);
		}
		
        public double calculaArea()
        {
            return (basis * height);
        }

        // getters() e setter()

        public void setBasis(double b)
        {
            basis = b;
        }

        public void setHeight(double h)
        {
            height = h;
        }

        public double calculaPerimetro()
        {
            return (2 * basis + 2 * height);
        }

    } // fim da classe Retangulo
}
