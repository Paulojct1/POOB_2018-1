using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05POOB_GUIempregado
{
	public class EmpregadoHORA : Empregado
	{
		protected int nro_horas;
		protected double preco_horas;

		public EmpregadoHORA()
		{

		}

		public EmpregadoHORA(string _nome, string _cpf, string _endereco, int _nro_horas, double _preco_horas) : base(_nome, _cpf, _endereco)
		{
			nro_horas = _nro_horas;
			preco_horas = _preco_horas;
		}

		public double getnHoras()
		{
			return nro_horas;
		}

		public void setnHoras(int _nro_horas)
		{
			this.nro_horas = _nro_horas;
		}

		public double getpHoras()
		{
			return preco_horas;
		}

		public void setpHoras(double _preco_horas)
		{
			this.preco_horas = _preco_horas;
		}

		public override double salarioLiquido()
		{
			return ((nro_horas * preco_horas) * 0.85);
		}
	}
}
