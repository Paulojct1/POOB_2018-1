using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
	class Program
	{
		static void Main(string[] args)
		{
			int quantidade = 2;
			Estacionamento[] matriz = new Estacionamento[quantidade];

			for (int j = 0; j < quantidade; j++)
			{
				Console.WriteLine((j + 1) + "\n  Veiculo de numero:\n");
				matriz[j] = new Estacionamento();
				matriz[j].dadosEstacionamento();
				Console.Clear();
			}

			Console.Clear();

			for (int k = 0; k < quantidade; k++)
			{
				Console.WriteLine((k + 1) + "\n  Veiculo de numero:\n");
				matriz[k].imprime();
				matriz[k].taxaCobrada();

				Console.ReadLine();
			}
		}
	}
}
