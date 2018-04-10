using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
	class Estacionamento
	{
		string placa, marca;
		Tempo entrada, saida;

		public Estacionamento()
		{
			placa = "";
			marca = "";
			entrada = new Tempo();
			saida = new Tempo();
		}

		public string getPlaca()
		{
			return placa;
		}

		public void setPlaca(string x)
		{
			placa = x;
		}

		public string getMarca()
		{
			return marca;
		}

		public void setMarca(string y)
		{
			marca = y;
		}

		public Tempo getEntrada()
		{
			return entrada;
		}

		public void setEntrada(Tempo w)
		{
			entrada = w;
		}

		public Tempo getSaida()
		{
			return saida;
		}

		public void setSaida(Tempo z)
		{
			saida = z;
		}

		public void dadosEstacionamento()
		{
			bool validade;

			Console.WriteLine("\n  Informe o numero da placa do veiculo: ");
			placa = Console.ReadLine();

			Console.WriteLine("\n  Informe a marca do veiculo: ");
			marca = Console.ReadLine();

			Console.WriteLine("\n  Informe o horario de entrada: ");
			entrada.dados();

			do
			{
				validade = true;

				Console.WriteLine("\n  Informe o horario de saida: ");
				saida.dados();

				if (saida.getHora() == entrada.getHora())
				{
					if (saida.getMinuto() == entrada.getMinuto())
					{
						if (saida.getSegundo() == entrada.getSegundo())
						{
							validade = false;
						}
					}
					else if (saida.getMinuto() < entrada.getMinuto())
					{
						validade = false;
					}
				}
				else if (saida.getHora() < entrada.getHora())
				{
					validade = false;
				}

				if (!validade)
				{
					Console.WriteLine("\n  O horario de saida eh invalido!");
				}
			}

			while (!validade);
		}

		public void imprime()
		{
			Console.WriteLine("\n  Placa do veiculo: " + placa);
			Console.WriteLine("\n  Marca do veiculo: " + marca);
			Console.WriteLine("\n  Horario de entrada do veiculo: ");
			entrada.imprime();
			Console.WriteLine("\n  Horario de saida do veiculo: ");
			saida.imprime();
		}

		public void taxaCobrada()
		{
			int preco;
			Tempo total = new Tempo();

			total = saida.subtrair(entrada);
			preco = 7 * total.getHora();

			if (total.getMinuto() > 0 || total.getSegundo() > 0)
			{
				preco = preco + 7;
			}

			Console.WriteLine("\n  O valor cobrado eh: " + preco);
		}
	}
}