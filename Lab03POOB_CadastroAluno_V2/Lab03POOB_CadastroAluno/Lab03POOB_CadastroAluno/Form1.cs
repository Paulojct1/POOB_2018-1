using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03POOB_CadastroAluno1
{
	public partial class cadastro : Form
	{
		public cadastro()
		{
			InitializeComponent();
		}

		private List<Materia> list_Materias = new List<Materia>();
		private Aluno[] array_alunos = new Aluno[10];
		private int contadorAlunos = 0;
		private string materias = "";

		private void label_nomeAluno_Click(object sender, EventArgs e)
		{

		}

		private void tb_nomeAluno_TextChanged(object sender, EventArgs e)
		{

		}

		private void button_cadastrar_Click(object sender, EventArgs e)
		{
			string[] temp;
			array_alunos[contadorAlunos] = new Aluno(tb_nomeAluno.Text,mtb_cpfAluno.Text, mtb_nroMatricula.Text);
			MessageBox.Show("Registro cadastrado com sucesso!");
			tb_nomeAluno.Text = "";
			mtb_cpfAluno.Text = "";
			mtb_nroMatricula.Text = "";

			temp = materias.Split(';');
			for (int index = 0; index < temp.Length; index++)
			{
				foreach (var item in list_Materias)
				{
					if (temp[index].Equals(item.getNomeMateria()))
					{
						array_alunos[contadorAlunos].addMateria(item);
					}
				}
			}

			contadorAlunos++;
			materias = "";
		}

		private void label_nomeMateria_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			list_Materias.Add(new Materia(tb_nomeMateria.Text, tb_codigo.Text));
			MessageBox.Show(" Matéria Cadastrada com Sucesso! ");
			tb_nomeMateria.Text = "";
			tb_codigo.Text = "";
		}

		private void tab_materia_Click(object sender, EventArgs e)
		{

		}

		private void tab_MouseClick(object sender, MouseEventArgs e)
		{
			int indexMateria = 0;
			comboBox1.Items.Clear();
			if (tab.SelectedTab.Text.Equals("Aluno"))
			{
				comboBox1.Items.Clear();
				foreach(var item in list_Materias)
				{
					comboBox1.Items.Insert(indexMateria,item.getNomeMateria());
					indexMateria++;
				}
			}

			int contadorRelatorio = 0;
			comboBox2.Items.Clear();
			if (tab.SelectedTab.Text.Equals("Relatório"))
			{
				comboBox2.Items.Clear();
				for (contadorRelatorio = 0; contadorRelatorio < contadorAlunos; contadorRelatorio++)
				{
					comboBox2.Items.Insert(contadorRelatorio, array_alunos[contadorRelatorio].getNome());
				}
			}
		}

		private void button_adicionar_Click(object sender, EventArgs e)
		{
			materias = materias + Convert.ToString(comboBox1.SelectedItem) + ";";
			MessageBox.Show(materias);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			textBox2.Text += array_alunos[comboBox2.SelectedIndex].Relatorio();
		}
	}
}
