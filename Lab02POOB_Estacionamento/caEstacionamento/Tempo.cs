using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
	class Tempo
	{
		int hora, minuto, segundo;

		public Tempo()
		{
			hora = 00;
			minuto = 00;
			segundo = 00;
		}

		public void dados()
		{
			int h, m, s;

			do
			{
				Console.Write("\n  Informe a hora: ");
				h = Convert.ToInt16(Console.ReadLine());

				if (h >= 24 || h < 00)
				{
					Console.WriteLine("\n  O valor eh invalido!");
				}
				else
				{
					hora = h;
				}
			}

			while (h >= 24 || h < 00);

			do
			{
				Console.Write("\n  Informe os minutos: ");
				m = Convert.ToInt16(Console.ReadLine());

				if (m >= 60 || m < 00)
				{
					Console.WriteLine("\n  O valor eh inválido!");
				}
				else
				{
					minuto = m;
				}
			}
			while (m >= 60 || m < 00);

			do
			{

				Console.Write("\n  Informe os segundos: ");
				s = Convert.ToInt16(Console.ReadLine());

				if (s >= 60 || s < 00)
				{
					Console.WriteLine("\n  O valor eh inválido!");
				}
				else
				{
					segundo = s;
				}
			}
			while (s >= 60 || s < 00);
		}

		public int getHora()
		{
			return hora;
		}

		public void setHora(int h)
		{
			hora = h;
		}

		public int getMinuto()
		{
			return minuto;
		}

		public void setMinuto(int m)
		{
			minuto = m;
		}

		public int getSegundo()
		{
			return segundo;
		}

		public void setSegundo(int s)
		{
			segundo = s;
		}

		public void imprime()
		{
			Console.WriteLine(string.Format("{0:0,0}", hora) + ":" + string.Format("{0:0,0}", minuto) + ":" + string.Format("{0:0,0}", segundo));
		}

		public Tempo adicionar(Tempo t1)
		{
			Tempo t2 = new Tempo();

			t2.segundo = segundo + t1.segundo;
			t2.minuto = minuto + t1.minuto;
			t2.hora = hora + t1.hora;

			if (t2.segundo >= 60)
			{
				t2.minuto++;
				t2.minuto = t2.minuto - 60;
			}

			return t2;
		}

		public Tempo subtrair(Tempo t1)
		{
			Tempo t2 = new Tempo();

			t2.hora = hora - t1.hora;

			if (t2.hora == 0)
			{
				t2.minuto = minuto - t1.minuto;

				if (t2.minuto == 0)
				{
					t2.segundo = t2.segundo - t1.segundo;
				}
				else
				{
					t2.segundo = segundo - t1.segundo;

					if (t2.segundo < 0)
					{
						t2.segundo = t2.segundo + 60;
						t2.minuto = t2.minuto - 1;
					}
				}
			}
			else
			{
				t2.minuto = minuto - t1.minuto;
				
				if (t2.minuto < 0)
				{
					t2.minuto = t2.minuto + 60;
					t2.hora = t2.hora - 1;
				}
			}

			return t2;
		}

	}
}