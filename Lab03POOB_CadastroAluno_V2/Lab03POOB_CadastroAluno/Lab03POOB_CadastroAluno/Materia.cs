using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03POOB_CadastroAluno1
{
	public class Materia
	{
		private string nomeMateria;
		private string codigo;

		public Materia()
		{
			nomeMateria = "";
			codigo = "";
		}

		public Materia(string nomeMateria, string codigo)
		{
			this.nomeMateria = nomeMateria;
			this.codigo = codigo;
		}

		public void setNome(string nomeMateria)
		{
			this.nomeMateria = nomeMateria;
		}

		public string getNomeMateria()
		{
			return nomeMateria;
		}

		public void setCodigo(string codigo)
		{
			this.codigo = codigo;
		}

		public string getCodigo()
		{
			return codigo;
		}
	}
}
