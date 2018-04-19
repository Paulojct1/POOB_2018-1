using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03POOB_CadastroAluno1
{
	public class Aluno
	{
		private string nome;
		private string cpf;
		private string nro_matricula;
		private Materia[] listaMateria;
		private int qtdMaterias;

		public Aluno()
		{
			nome = "";
			cpf = "";
			nro_matricula = "";
			listaMateria = new Materia[10];
			qtdMaterias = 0;
		}

		public Aluno(string nome, string cpf, string nro_matricula)
		{
			this.nome = nome;
			this.cpf = cpf;
			this.nro_matricula = nro_matricula;
			listaMateria = new Materia[10];
			qtdMaterias = 0;
		}

		public void setNome(string nome)
		{
			this.nome = nome;
		}

		public string getNome()
		{
			return nome;
		}

		public void setCpf(string cpf)
		{
			this.cpf = cpf;
		}

		public string getCpf()
		{
			return cpf;
		}

		public void setNro_matricula(string nro_matricula)
		{
			this.nro_matricula = nro_matricula;
		}

		public string getNro_matricula()
		{
			return nro_matricula;
		}

		public void addMateria(Materia m)
		{
			listaMateria[qtdMaterias] = m;
			qtdMaterias++;
		}

		public string Relatorio()
		{
			string relatorio = "";
			relatorio = "Nome:\t" + nome + "\r\n";
			relatorio += "CPF:\t" + cpf + "\r\n";
			relatorio += "Numero de Matricula:\t" + nro_matricula + "\r\n";
			relatorio += "Materias Inscritas:\t\t" + "Codigo:\r\n";
			for (int index = 0; index < qtdMaterias; index++)
			{
				relatorio += listaMateria[index].getNomeMateria() + "\t\t\t" +
					listaMateria[index].getCodigo() + "\r\n";
			}

			return relatorio;
		}
	}
}
