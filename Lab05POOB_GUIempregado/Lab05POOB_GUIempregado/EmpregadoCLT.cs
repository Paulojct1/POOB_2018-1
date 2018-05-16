using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05POOB_GUIempregado
{
	public class EmpregadoCLT : Empregado
	{
		private double sBrutoCLT;

		public EmpregadoCLT()
		{

		}

		public EmpregadoCLT(string _nome, string _cpf, string _endereco, double _sBrutoCLT) : base (_nome, _cpf, _endereco)
		{
			sBrutoCLT = _sBrutoCLT;
		}

		public double getsBrutoCLT()
		{
			return sBrutoCLT;
		}

		public void setsBrutoCLT(double sBrutoCLT)
		{
			this.sBrutoCLT = sBrutoCLT;
		}

		public override double salarioLiquido()
		{
			if (sBrutoCLT <= 5000)
			{
				return (sBrutoCLT * 0.85);
			}
			else
			{
				return (sBrutoCLT * 0.725);
			}
		}
	}
}
