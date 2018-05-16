using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05POOB_GUIempregado
{
	public class Empregado
	{
		protected string nome;
		protected string cpf;
		protected string endereco;

		public Empregado()
		{

		}

		public Empregado(string _nome, string _cpf, string _endereco)
		{
			nome = _nome;
			cpf = _cpf;
			endereco = _endereco;
		}

		public string getCpf()
		{
			return cpf;
		}

		public void setCpf(string cpf)
		{
			this.cpf = cpf;
		}

		public string getNome()
		{
			return nome;
		}

		public void setNome(string nome)
		{
			this.nome = nome;
		}

		public string getEndereco()
		{
			return endereco;
		}

		public void setEndereco(string endereco)
		{
			this.endereco = endereco;
		}

		public virtual double salarioLiquido()
		{
			return 1.0;
		}
	}
}
