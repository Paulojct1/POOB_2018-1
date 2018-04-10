using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01POOB_2DVector
{
	class Vector
	{
		// Declaração de Variáveis

		public double a1;
		public double b1;


		//  Declaração do Vetor Vazio

		public Vector()
		{

		}


		//  Declaração do Vetor a receber variáveis

		public Vector(double a1, double b1)
		{
			this.a1 = a1;
			this.b1 = b1;
		}


		// Setter e Getters

		public void setA(double a1)
		{
			this.a1 = a1;
		}

		public void setB(double b1)
		{
			this.b1 = b1;
		}

		public double getA()
		{
			return a1;
		}

		public double getB()
		{
			return b1;
		}


		// Função de retorno produto escalar

		public double prod_escalar(double a2, double b2)
		{
			double f1 = a1 * a2;
			double f2 = b1 * b2;
			return (f1 + f2);
		}


		// Função de retorno do módulo

		public double modulo()
		{
			return Math.Sqrt((a1 * a1) + (b1 * b1));
		}


		// Função de retorno do módulo para 2 entradas

		public double modulo_2Ents(double a2, double b2)
		{
			return Math.Sqrt((a2 * a2) + (b2 * b2));
		}


		// Função de retorno do ângulo dos vetores

		public double angle(double a2, double b2)
		{
			double produto_escalar = this.prod_escalar(a2, b2);
			double modulo_Vector1 = modulo();
			double modulo_Vector2 = modulo_2Ents(a2, b2);
			double retorno = Math.Acos((produto_escalar) / (modulo_Vector1 * modulo_Vector2));
			return retorno;
		}


		// Função de retorno do valor do Vetor 1 no Vetor 2

		public Vector projecao(Vector entrada)
		{
			Vector projVector = new Vector();
			double produto_escalar = this.prod_escalar(entrada.a1, entrada.b1);
			double denominador = modulo_2Ents(entrada.a1, entrada.b1);
			denominador = denominador * denominador;
			double divisao = produto_escalar / denominador;
			double a1_resultado = divisao * entrada.a1;
			double b1_resultado = divisao * entrada.b1;
			projVector.setA(a1_resultado);
			projVector.setB(b1_resultado);
			return projVector;
		}
	}
}
