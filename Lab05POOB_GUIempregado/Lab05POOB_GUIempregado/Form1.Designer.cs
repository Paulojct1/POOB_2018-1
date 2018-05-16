namespace Lab05POOB_GUIempregado
{
	partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCadastro = new System.Windows.Forms.TabPage();
			this.tabRelatorio = new System.Windows.Forms.TabPage();
			this.label_nome = new System.Windows.Forms.Label();
			this.label_cpf = new System.Windows.Forms.Label();
			this.label_endereco = new System.Windows.Forms.Label();
			this.label_salario = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_nome = new System.Windows.Forms.TextBox();
			this.tb_salario = new System.Windows.Forms.TextBox();
			this.tb_endereco = new System.Windows.Forms.TextBox();
			this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
			this.rb_clt = new System.Windows.Forms.RadioButton();
			this.rb_horista = new System.Windows.Forms.RadioButton();
			this.bt_Registrar = new System.Windows.Forms.Button();
			this.label_nroHoras = new System.Windows.Forms.Label();
			this.tb_nroHoras = new System.Windows.Forms.TextBox();
			this.label_precoHora = new System.Windows.Forms.Label();
			this.tb_precoHora = new System.Windows.Forms.TextBox();
			this.bt_gerarRelatorio = new System.Windows.Forms.Button();
			this.tb_relatorio = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabCadastro.SuspendLayout();
			this.tabRelatorio.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCadastro);
			this.tabControl1.Controls.Add(this.tabRelatorio);
			this.tabControl1.Location = new System.Drawing.Point(2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(589, 386);
			this.tabControl1.TabIndex = 0;
			// 
			// tabCadastro
			// 
			this.tabCadastro.Controls.Add(this.bt_Registrar);
			this.tabCadastro.Controls.Add(this.mtb_cpf);
			this.tabCadastro.Controls.Add(this.tb_endereco);
			this.tabCadastro.Controls.Add(this.tb_precoHora);
			this.tabCadastro.Controls.Add(this.tb_nroHoras);
			this.tabCadastro.Controls.Add(this.tb_salario);
			this.tabCadastro.Controls.Add(this.tb_nome);
			this.tabCadastro.Controls.Add(this.groupBox1);
			this.tabCadastro.Controls.Add(this.label_precoHora);
			this.tabCadastro.Controls.Add(this.label_nroHoras);
			this.tabCadastro.Controls.Add(this.label_salario);
			this.tabCadastro.Controls.Add(this.label_endereco);
			this.tabCadastro.Controls.Add(this.label_cpf);
			this.tabCadastro.Controls.Add(this.label_nome);
			this.tabCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tabCadastro.Location = new System.Drawing.Point(4, 22);
			this.tabCadastro.Name = "tabCadastro";
			this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastro.Size = new System.Drawing.Size(581, 360);
			this.tabCadastro.TabIndex = 0;
			this.tabCadastro.Text = "Cadastro";
			this.tabCadastro.UseVisualStyleBackColor = true;
			this.tabCadastro.Click += new System.EventHandler(this.tabCadastro_Click);
			// 
			// tabRelatorio
			// 
			this.tabRelatorio.Controls.Add(this.tb_relatorio);
			this.tabRelatorio.Controls.Add(this.bt_gerarRelatorio);
			this.tabRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
			this.tabRelatorio.Name = "tabRelatorio";
			this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
			this.tabRelatorio.Size = new System.Drawing.Size(581, 360);
			this.tabRelatorio.TabIndex = 1;
			this.tabRelatorio.Text = "Relatório";
			this.tabRelatorio.UseVisualStyleBackColor = true;
			// 
			// label_nome
			// 
			this.label_nome.AutoSize = true;
			this.label_nome.Location = new System.Drawing.Point(30, 50);
			this.label_nome.Name = "label_nome";
			this.label_nome.Size = new System.Drawing.Size(41, 15);
			this.label_nome.TabIndex = 0;
			this.label_nome.Text = "Nome";
			// 
			// label_cpf
			// 
			this.label_cpf.AutoSize = true;
			this.label_cpf.Location = new System.Drawing.Point(30, 100);
			this.label_cpf.Name = "label_cpf";
			this.label_cpf.Size = new System.Drawing.Size(30, 15);
			this.label_cpf.TabIndex = 0;
			this.label_cpf.Text = "CPF";
			// 
			// label_endereco
			// 
			this.label_endereco.AutoSize = true;
			this.label_endereco.Location = new System.Drawing.Point(30, 150);
			this.label_endereco.Name = "label_endereco";
			this.label_endereco.Size = new System.Drawing.Size(60, 15);
			this.label_endereco.TabIndex = 0;
			this.label_endereco.Text = "Endereço";
			// 
			// label_salario
			// 
			this.label_salario.AutoSize = true;
			this.label_salario.Location = new System.Drawing.Point(30, 200);
			this.label_salario.Name = "label_salario";
			this.label_salario.Size = new System.Drawing.Size(46, 15);
			this.label_salario.TabIndex = 0;
			this.label_salario.Text = "Salário";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rb_horista);
			this.groupBox1.Controls.Add(this.rb_clt);
			this.groupBox1.Location = new System.Drawing.Point(439, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(113, 130);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo Empregado";
			// 
			// tb_nome
			// 
			this.tb_nome.Location = new System.Drawing.Point(77, 50);
			this.tb_nome.Name = "tb_nome";
			this.tb_nome.Size = new System.Drawing.Size(356, 21);
			this.tb_nome.TabIndex = 2;
			// 
			// tb_salario
			// 
			this.tb_salario.Location = new System.Drawing.Point(82, 197);
			this.tb_salario.Name = "tb_salario";
			this.tb_salario.Size = new System.Drawing.Size(351, 21);
			this.tb_salario.TabIndex = 2;
			this.tb_salario.TextChanged += new System.EventHandler(this.tb_salario_TextChanged);
			// 
			// tb_endereco
			// 
			this.tb_endereco.Location = new System.Drawing.Point(96, 150);
			this.tb_endereco.Name = "tb_endereco";
			this.tb_endereco.Size = new System.Drawing.Size(337, 21);
			this.tb_endereco.TabIndex = 2;
			// 
			// mtb_cpf
			// 
			this.mtb_cpf.Location = new System.Drawing.Point(67, 100);
			this.mtb_cpf.Mask = "         000.000.000-00";
			this.mtb_cpf.Name = "mtb_cpf";
			this.mtb_cpf.Size = new System.Drawing.Size(366, 21);
			this.mtb_cpf.TabIndex = 3;
			// 
			// rb_clt
			// 
			this.rb_clt.AutoSize = true;
			this.rb_clt.Location = new System.Drawing.Point(23, 39);
			this.rb_clt.Name = "rb_clt";
			this.rb_clt.Size = new System.Drawing.Size(47, 19);
			this.rb_clt.TabIndex = 4;
			this.rb_clt.TabStop = true;
			this.rb_clt.Text = "CLT";
			this.rb_clt.UseVisualStyleBackColor = true;
			this.rb_clt.CheckedChanged += new System.EventHandler(this.rb_clt_CheckedChanged);
			// 
			// rb_horista
			// 
			this.rb_horista.AutoSize = true;
			this.rb_horista.Location = new System.Drawing.Point(23, 64);
			this.rb_horista.Name = "rb_horista";
			this.rb_horista.Size = new System.Drawing.Size(64, 19);
			this.rb_horista.TabIndex = 4;
			this.rb_horista.TabStop = true;
			this.rb_horista.Text = "Horista";
			this.rb_horista.UseVisualStyleBackColor = true;
			this.rb_horista.CheckedChanged += new System.EventHandler(this.rb_horista_CheckedChanged);
			// 
			// bt_Registrar
			// 
			this.bt_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.bt_Registrar.Location = new System.Drawing.Point(178, 300);
			this.bt_Registrar.Name = "bt_Registrar";
			this.bt_Registrar.Size = new System.Drawing.Size(225, 41);
			this.bt_Registrar.TabIndex = 4;
			this.bt_Registrar.Text = "Registrar";
			this.bt_Registrar.UseVisualStyleBackColor = true;
			this.bt_Registrar.Click += new System.EventHandler(this.bt_Registrar_Click);
			// 
			// label_nroHoras
			// 
			this.label_nroHoras.AutoSize = true;
			this.label_nroHoras.Location = new System.Drawing.Point(30, 250);
			this.label_nroHoras.Name = "label_nroHoras";
			this.label_nroHoras.Size = new System.Drawing.Size(105, 15);
			this.label_nroHoras.TabIndex = 0;
			this.label_nroHoras.Text = "Número de Horas";
			// 
			// tb_nroHoras
			// 
			this.tb_nroHoras.Location = new System.Drawing.Point(141, 247);
			this.tb_nroHoras.Name = "tb_nroHoras";
			this.tb_nroHoras.Size = new System.Drawing.Size(84, 21);
			this.tb_nroHoras.TabIndex = 2;
			this.tb_nroHoras.TextChanged += new System.EventHandler(this.tb_salario_TextChanged);
			// 
			// label_precoHora
			// 
			this.label_precoHora.AutoSize = true;
			this.label_precoHora.Location = new System.Drawing.Point(263, 250);
			this.label_precoHora.Name = "label_precoHora";
			this.label_precoHora.Size = new System.Drawing.Size(69, 15);
			this.label_precoHora.TabIndex = 0;
			this.label_precoHora.Text = "Preço Hora";
			// 
			// tb_precoHora
			// 
			this.tb_precoHora.Location = new System.Drawing.Point(338, 247);
			this.tb_precoHora.Name = "tb_precoHora";
			this.tb_precoHora.Size = new System.Drawing.Size(95, 21);
			this.tb_precoHora.TabIndex = 2;
			this.tb_precoHora.TextChanged += new System.EventHandler(this.tb_salario_TextChanged);
			// 
			// bt_gerarRelatorio
			// 
			this.bt_gerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.bt_gerarRelatorio.Location = new System.Drawing.Point(10, 10);
			this.bt_gerarRelatorio.Name = "bt_gerarRelatorio";
			this.bt_gerarRelatorio.Size = new System.Drawing.Size(565, 41);
			this.bt_gerarRelatorio.TabIndex = 0;
			this.bt_gerarRelatorio.Text = "Gerar Relatório";
			this.bt_gerarRelatorio.UseVisualStyleBackColor = true;
			this.bt_gerarRelatorio.Click += new System.EventHandler(this.bt_gerarRelatorio_Click);
			// 
			// tb_relatorio
			// 
			this.tb_relatorio.Location = new System.Drawing.Point(10, 58);
			this.tb_relatorio.Multiline = true;
			this.tb_relatorio.Name = "tb_relatorio";
			this.tb_relatorio.Size = new System.Drawing.Size(565, 296);
			this.tb_relatorio.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 390);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Cadastro de Empregados";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabCadastro.ResumeLayout(false);
			this.tabCadastro.PerformLayout();
			this.tabRelatorio.ResumeLayout(false);
			this.tabRelatorio.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabCadastro;
		private System.Windows.Forms.TabPage tabRelatorio;
		private System.Windows.Forms.MaskedTextBox mtb_cpf;
		private System.Windows.Forms.TextBox tb_endereco;
		private System.Windows.Forms.TextBox tb_salario;
		private System.Windows.Forms.TextBox tb_nome;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label_salario;
		private System.Windows.Forms.Label label_endereco;
		private System.Windows.Forms.Label label_cpf;
		private System.Windows.Forms.Label label_nome;
		private System.Windows.Forms.RadioButton rb_horista;
		private System.Windows.Forms.RadioButton rb_clt;
		private System.Windows.Forms.Button bt_Registrar;
		private System.Windows.Forms.Label label_nroHoras;
		private System.Windows.Forms.TextBox tb_precoHora;
		private System.Windows.Forms.TextBox tb_nroHoras;
		private System.Windows.Forms.Label label_precoHora;
		private System.Windows.Forms.Button bt_gerarRelatorio;
		private System.Windows.Forms.TextBox tb_relatorio;
	}
}

