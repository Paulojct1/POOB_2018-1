using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05POOB_GUIempregado
{
	public partial class Form1 : Form
	{
		Empregado[] empregados = new Empregado[10];

		int index = 0;

		EmpregadoCLT temp1 = new EmpregadoCLT();
		EmpregadoHORA temp2 = new EmpregadoHORA();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tb_salario_TextChanged(object sender, EventArgs e)
		{

		}

		private void tabCadastro_Click(object sender, EventArgs e)
		{

		}

		private void clearCLT_tb()
		{
			tb_nome.Text = "";
			mtb_cpf.Text = "";
			tb_endereco.Text = "";
			tb_salario.Text = "";

		}

		private void clearHorista_tb()
		{
			tb_nome.Text = "";
			mtb_cpf.Text = "";
			tb_endereco.Text = "";
			tb_nroHoras.Text = "";
			tb_precoHora.Text = "";

		}

		private void bt_Registrar_Click(object sender, EventArgs e)
		{
			if (rb_clt.Checked)
			{
				temp1.setNome(tb_nome.Text);
				temp1.setCpf(mtb_cpf.Text);
				temp1.setEndereco(tb_endereco.Text);
				temp1.setsBrutoCLT(Convert.ToDouble(tb_salario.Text));
				clearCLT_tb();

				empregados[index] = temp1;
				index++;
				MessageBox.Show("  Registro efetuado com sucesso! ");
			}

			if (rb_horista.Checked)
			{
				temp2.setNome(tb_nome.Text);
				temp2.setCpf(mtb_cpf.Text);
				temp2.setEndereco(tb_endereco.Text);
				temp2.setnHoras(Convert.ToInt16(tb_nroHoras.Text));
				temp2.setpHoras(Convert.ToDouble(tb_precoHora.Text));
				clearHorista_tb();

				empregados[index] = temp2;
				index++;
				MessageBox.Show("  Registro efetuado com sucesso! ");
			}

		}

		private void rb_clt_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rb_horista_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void bt_gerarRelatorio_Click(object sender, EventArgs e)
		{
			tb_relatorio.Text = "";
			//tb_relatorio.Text += 
		}
	}
}
