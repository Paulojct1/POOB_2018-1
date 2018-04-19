namespace Lab03POOB_CadastroAluno1
{
	partial class cadastro
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.tab = new System.Windows.Forms.TabControl();
			this.tab_aluno = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button_cadastrar = new System.Windows.Forms.Button();
			this.button_adicionar = new System.Windows.Forms.Button();
			this.mtb_cpfAluno = new System.Windows.Forms.MaskedTextBox();
			this.mtb_nroMatricula = new System.Windows.Forms.MaskedTextBox();
			this.tb_nomeAluno = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label_nroMatricula = new System.Windows.Forms.Label();
			this.label_materia = new System.Windows.Forms.Label();
			this.label_cpfAluno = new System.Windows.Forms.Label();
			this.tab_materia = new System.Windows.Forms.TabPage();
			this.button_cadastrarMateria = new System.Windows.Forms.Button();
			this.tb_codigo = new System.Windows.Forms.TextBox();
			this.tb_nomeMateria = new System.Windows.Forms.TextBox();
			this.label_codigo = new System.Windows.Forms.Label();
			this.label_nomeMateria = new System.Windows.Forms.Label();
			this.tab_relatorio = new System.Windows.Forms.TabPage();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label_aluno = new System.Windows.Forms.Label();
			this.tab.SuspendLayout();
			this.tab_aluno.SuspendLayout();
			this.tab_materia.SuspendLayout();
			this.tab_relatorio.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tab_aluno);
			this.tab.Controls.Add(this.tab_materia);
			this.tab.Controls.Add(this.tab_relatorio);
			this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.tab.Location = new System.Drawing.Point(0, -1);
			this.tab.Name = "tab";
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(461, 452);
			this.tab.TabIndex = 0;
			this.tab.Tag = "";
			this.tab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_MouseClick);
			// 
			// tab_aluno
			// 
			this.tab_aluno.Controls.Add(this.comboBox1);
			this.tab_aluno.Controls.Add(this.button_cadastrar);
			this.tab_aluno.Controls.Add(this.button_adicionar);
			this.tab_aluno.Controls.Add(this.mtb_cpfAluno);
			this.tab_aluno.Controls.Add(this.mtb_nroMatricula);
			this.tab_aluno.Controls.Add(this.tb_nomeAluno);
			this.tab_aluno.Controls.Add(this.label1);
			this.tab_aluno.Controls.Add(this.label_nroMatricula);
			this.tab_aluno.Controls.Add(this.label_materia);
			this.tab_aluno.Controls.Add(this.label_cpfAluno);
			this.tab_aluno.Location = new System.Drawing.Point(4, 22);
			this.tab_aluno.Name = "tab_aluno";
			this.tab_aluno.Padding = new System.Windows.Forms.Padding(3);
			this.tab_aluno.Size = new System.Drawing.Size(453, 426);
			this.tab_aluno.TabIndex = 0;
			this.tab_aluno.Text = "Aluno";
			this.tab_aluno.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(25, 274);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(161, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button_cadastrar
			// 
			this.button_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.button_cadastrar.Location = new System.Drawing.Point(354, 379);
			this.button_cadastrar.Name = "button_cadastrar";
			this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
			this.button_cadastrar.TabIndex = 3;
			this.button_cadastrar.Text = "Cadastrar";
			this.button_cadastrar.UseVisualStyleBackColor = true;
			this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
			// 
			// button_adicionar
			// 
			this.button_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.button_adicionar.Location = new System.Drawing.Point(208, 274);
			this.button_adicionar.Name = "button_adicionar";
			this.button_adicionar.Size = new System.Drawing.Size(75, 23);
			this.button_adicionar.TabIndex = 3;
			this.button_adicionar.Text = "Adicionar";
			this.button_adicionar.UseVisualStyleBackColor = true;
			this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
			// 
			// mtb_cpfAluno
			// 
			this.mtb_cpfAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mtb_cpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.mtb_cpfAluno.Location = new System.Drawing.Point(25, 133);
			this.mtb_cpfAluno.Mask = "000.000.000-00";
			this.mtb_cpfAluno.Name = "mtb_cpfAluno";
			this.mtb_cpfAluno.Size = new System.Drawing.Size(111, 21);
			this.mtb_cpfAluno.TabIndex = 2;
			this.mtb_cpfAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mtb_nroMatricula
			// 
			this.mtb_nroMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mtb_nroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.mtb_nroMatricula.Location = new System.Drawing.Point(25, 208);
			this.mtb_nroMatricula.Mask = "00000AAA000";
			this.mtb_nroMatricula.Name = "mtb_nroMatricula";
			this.mtb_nroMatricula.Size = new System.Drawing.Size(137, 21);
			this.mtb_nroMatricula.TabIndex = 2;
			this.mtb_nroMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_nomeAluno
			// 
			this.tb_nomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_nomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tb_nomeAluno.Location = new System.Drawing.Point(25, 57);
			this.tb_nomeAluno.Name = "tb_nomeAluno";
			this.tb_nomeAluno.Size = new System.Drawing.Size(404, 21);
			this.tb_nomeAluno.TabIndex = 1;
			this.tb_nomeAluno.TextChanged += new System.EventHandler(this.tb_nomeAluno_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label1.Location = new System.Drawing.Point(30, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			this.label1.Click += new System.EventHandler(this.label_nomeAluno_Click);
			// 
			// label_nroMatricula
			// 
			this.label_nroMatricula.AutoSize = true;
			this.label_nroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label_nroMatricula.Location = new System.Drawing.Point(30, 190);
			this.label_nroMatricula.Name = "label_nroMatricula";
			this.label_nroMatricula.Size = new System.Drawing.Size(123, 15);
			this.label_nroMatricula.TabIndex = 0;
			this.label_nroMatricula.Text = "Número de Matrícula";
			this.label_nroMatricula.Click += new System.EventHandler(this.label_nomeAluno_Click);
			// 
			// label_materia
			// 
			this.label_materia.AutoSize = true;
			this.label_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label_materia.Location = new System.Drawing.Point(30, 256);
			this.label_materia.Name = "label_materia";
			this.label_materia.Size = new System.Drawing.Size(49, 15);
			this.label_materia.TabIndex = 0;
			this.label_materia.Text = "Matéria";
			this.label_materia.Click += new System.EventHandler(this.label_nomeAluno_Click);
			// 
			// label_cpfAluno
			// 
			this.label_cpfAluno.AutoSize = true;
			this.label_cpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label_cpfAluno.Location = new System.Drawing.Point(30, 115);
			this.label_cpfAluno.Name = "label_cpfAluno";
			this.label_cpfAluno.Size = new System.Drawing.Size(30, 15);
			this.label_cpfAluno.TabIndex = 0;
			this.label_cpfAluno.Text = "CPF";
			this.label_cpfAluno.Click += new System.EventHandler(this.label_nomeAluno_Click);
			// 
			// tab_materia
			// 
			this.tab_materia.Controls.Add(this.button_cadastrarMateria);
			this.tab_materia.Controls.Add(this.tb_codigo);
			this.tab_materia.Controls.Add(this.tb_nomeMateria);
			this.tab_materia.Controls.Add(this.label_codigo);
			this.tab_materia.Controls.Add(this.label_nomeMateria);
			this.tab_materia.Location = new System.Drawing.Point(4, 22);
			this.tab_materia.Name = "tab_materia";
			this.tab_materia.Padding = new System.Windows.Forms.Padding(3);
			this.tab_materia.Size = new System.Drawing.Size(453, 426);
			this.tab_materia.TabIndex = 1;
			this.tab_materia.Text = "Matéria";
			this.tab_materia.UseVisualStyleBackColor = true;
			this.tab_materia.Click += new System.EventHandler(this.tab_materia_Click);
			// 
			// button_cadastrarMateria
			// 
			this.button_cadastrarMateria.Location = new System.Drawing.Point(278, 142);
			this.button_cadastrarMateria.Name = "button_cadastrarMateria";
			this.button_cadastrarMateria.Size = new System.Drawing.Size(75, 23);
			this.button_cadastrarMateria.TabIndex = 2;
			this.button_cadastrarMateria.Text = "Cadastrar";
			this.button_cadastrarMateria.UseVisualStyleBackColor = true;
			this.button_cadastrarMateria.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_codigo
			// 
			this.tb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tb_codigo.Location = new System.Drawing.Point(25, 142);
			this.tb_codigo.Name = "tb_codigo";
			this.tb_codigo.Size = new System.Drawing.Size(155, 21);
			this.tb_codigo.TabIndex = 1;
			this.tb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_nomeMateria
			// 
			this.tb_nomeMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_nomeMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tb_nomeMateria.Location = new System.Drawing.Point(25, 57);
			this.tb_nomeMateria.Name = "tb_nomeMateria";
			this.tb_nomeMateria.Size = new System.Drawing.Size(155, 21);
			this.tb_nomeMateria.TabIndex = 1;
			this.tb_nomeMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_codigo
			// 
			this.label_codigo.AutoSize = true;
			this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label_codigo.Location = new System.Drawing.Point(30, 124);
			this.label_codigo.Name = "label_codigo";
			this.label_codigo.Size = new System.Drawing.Size(46, 15);
			this.label_codigo.TabIndex = 0;
			this.label_codigo.Text = "Código";
			// 
			// label_nomeMateria
			// 
			this.label_nomeMateria.AutoSize = true;
			this.label_nomeMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.label_nomeMateria.Location = new System.Drawing.Point(30, 39);
			this.label_nomeMateria.Name = "label_nomeMateria";
			this.label_nomeMateria.Size = new System.Drawing.Size(49, 15);
			this.label_nomeMateria.TabIndex = 0;
			this.label_nomeMateria.Text = "Matéria";
			this.label_nomeMateria.Click += new System.EventHandler(this.label_nomeMateria_Click);
			// 
			// tab_relatorio
			// 
			this.tab_relatorio.Controls.Add(this.comboBox2);
			this.tab_relatorio.Controls.Add(this.button2);
			this.tab_relatorio.Controls.Add(this.textBox2);
			this.tab_relatorio.Controls.Add(this.label_aluno);
			this.tab_relatorio.Location = new System.Drawing.Point(4, 22);
			this.tab_relatorio.Name = "tab_relatorio";
			this.tab_relatorio.Padding = new System.Windows.Forms.Padding(3);
			this.tab_relatorio.Size = new System.Drawing.Size(453, 426);
			this.tab_relatorio.TabIndex = 2;
			this.tab_relatorio.Text = "Relatório";
			this.tab_relatorio.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(25, 58);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(276, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(325, 58);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Gerar Relatório";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textBox2.Location = new System.Drawing.Point(25, 98);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(404, 308);
			this.textBox2.TabIndex = 2;
			// 
			// label_aluno
			// 
			this.label_aluno.AutoSize = true;
			this.label_aluno.Location = new System.Drawing.Point(30, 39);
			this.label_aluno.Name = "label_aluno";
			this.label_aluno.Size = new System.Drawing.Size(38, 15);
			this.label_aluno.TabIndex = 0;
			this.label_aluno.Text = "Aluno";
			// 
			// cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 450);
			this.Controls.Add(this.tab);
			this.Name = "cadastro";
			this.Text = "Cadastro Aluno e Matérias";
			this.tab.ResumeLayout(false);
			this.tab_aluno.ResumeLayout(false);
			this.tab_aluno.PerformLayout();
			this.tab_materia.ResumeLayout(false);
			this.tab_materia.PerformLayout();
			this.tab_relatorio.ResumeLayout(false);
			this.tab_relatorio.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tab;
		private System.Windows.Forms.TabPage tab_aluno;
		private System.Windows.Forms.TextBox tb_nomeAluno;
		private System.Windows.Forms.Label label_cpfAluno;
		private System.Windows.Forms.TabPage tab_materia;
		private System.Windows.Forms.TabPage tab_relatorio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox mtb_nroMatricula;
		private System.Windows.Forms.MaskedTextBox mtb_cpfAluno;
		private System.Windows.Forms.Label label_nroMatricula;
		private System.Windows.Forms.Label label_materia;
		private System.Windows.Forms.Button button_cadastrar;
		private System.Windows.Forms.Button button_adicionar;
		private System.Windows.Forms.Button button_cadastrarMateria;
		private System.Windows.Forms.TextBox tb_codigo;
		private System.Windows.Forms.TextBox tb_nomeMateria;
		private System.Windows.Forms.Label label_codigo;
		private System.Windows.Forms.Label label_nomeMateria;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label_aluno;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
	}
}

