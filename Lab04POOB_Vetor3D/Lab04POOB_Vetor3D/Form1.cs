using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04POOB_Vetor3D
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btModulo1_Click(object sender, EventArgs e)
		{
			Double x = double.Parse(tbx1.Text);
			Double y = double.Parse(tby1.Text);
			Double z = double.Parse(tbz1.Text);
			Vetor3D vetorA = new Vetor3D(x, y, z);
			Double resultado = vetorA.mod();
			tbResultado.Text = Convert.ToString(resultado);

		}

		private void btModulo2_Click(object sender, EventArgs e)
		{
			Double x = double.Parse(tbx2.Text);
			Double y = double.Parse(tby2.Text);
			Double z = double.Parse(tbz2.Text);
			Vetor3D vetorB = new Vetor3D(x, y, z);
			Double resultado = vetorB.mod();
			tbResultado.Text = Convert.ToString(resultado);
		}

		private void btProdVet_Click(object sender, EventArgs e)
		{
			Vetor3D vetorC = new Vetor3D();
			Double xa = double.Parse(tbx1.Text);
			Double ya = double.Parse(tby1.Text);
			Double za = double.Parse(tbz1.Text);
			Vetor3D vetorA = new Vetor3D(xa, ya, za);
			Double xb = double.Parse(tbx2.Text);
			Double yb = double.Parse(tby2.Text);
			Double zb = double.Parse(tbz2.Text);
			Vetor3D vetorB = new Vetor3D(xb, yb, zb);
			vetorC = vetorA.prod_vet(vetorB);
			tbResultado.Text = "(" + vetorC.getX() + "," + vetorC.getY() + "," + vetorC.getZ() + ")";
		}
	}
}
