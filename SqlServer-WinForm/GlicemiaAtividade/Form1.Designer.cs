namespace GlicemiaAtividade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdMedida = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.button1_Conectar = new System.Windows.Forms.Button();
            this.button2_Cadastrar = new System.Windows.Forms.Button();
            this.button3_Deletar = new System.Windows.Forms.Button();
            this.button4_Editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2_Gravar = new System.Windows.Forms.Button();
            this.button1_Limpar = new System.Windows.Forms.Button();
            this.textBox5_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4_Paciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3_IdPaciente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_DataMedicao = new System.Windows.Forms.DateTimePicker();
            this.textBox2_ValorGlicemico = new System.Windows.Forms.TextBox();
            this.textBox1_IdGlicemia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdMedida,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(642, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IdMedida
            // 
            this.IdMedida.Text = "IdMedida";
            this.IdMedida.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valor Glicêmico";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Medição";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Paciente";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id Paciente";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // button1_Conectar
            // 
            this.button1_Conectar.Location = new System.Drawing.Point(12, 212);
            this.button1_Conectar.Name = "button1_Conectar";
            this.button1_Conectar.Size = new System.Drawing.Size(83, 34);
            this.button1_Conectar.TabIndex = 1;
            this.button1_Conectar.Text = "Conectar";
            this.button1_Conectar.UseVisualStyleBackColor = true;
            this.button1_Conectar.Click += new System.EventHandler(this.button1_Conectar_Click);
            // 
            // button2_Cadastrar
            // 
            this.button2_Cadastrar.Enabled = false;
            this.button2_Cadastrar.Location = new System.Drawing.Point(101, 212);
            this.button2_Cadastrar.Name = "button2_Cadastrar";
            this.button2_Cadastrar.Size = new System.Drawing.Size(122, 34);
            this.button2_Cadastrar.TabIndex = 2;
            this.button2_Cadastrar.Text = "Cadastrar/Atualizar";
            this.button2_Cadastrar.UseVisualStyleBackColor = true;
            this.button2_Cadastrar.Click += new System.EventHandler(this.button2_Cadastrar_Click);
            // 
            // button3_Deletar
            // 
            this.button3_Deletar.Enabled = false;
            this.button3_Deletar.Location = new System.Drawing.Point(229, 212);
            this.button3_Deletar.Name = "button3_Deletar";
            this.button3_Deletar.Size = new System.Drawing.Size(83, 34);
            this.button3_Deletar.TabIndex = 3;
            this.button3_Deletar.Text = "Deletar";
            this.button3_Deletar.UseVisualStyleBackColor = true;
            this.button3_Deletar.Click += new System.EventHandler(this.button3_Deletar_Click);
            // 
            // button4_Editar
            // 
            this.button4_Editar.Enabled = false;
            this.button4_Editar.Location = new System.Drawing.Point(318, 212);
            this.button4_Editar.Name = "button4_Editar";
            this.button4_Editar.Size = new System.Drawing.Size(83, 34);
            this.button4_Editar.TabIndex = 4;
            this.button4_Editar.Text = "Editar";
            this.button4_Editar.UseVisualStyleBackColor = true;
            this.button4_Editar.Click += new System.EventHandler(this.button4_Editar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2_Gravar);
            this.panel1.Controls.Add(this.button1_Limpar);
            this.panel1.Controls.Add(this.textBox5_Email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox4_Paciente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox3_IdPaciente);
            this.panel1.Controls.Add(this.dateTimePicker1_DataMedicao);
            this.panel1.Controls.Add(this.textBox2_ValorGlicemico);
            this.panel1.Controls.Add(this.textBox1_IdGlicemia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 244);
            this.panel1.TabIndex = 5;
            // 
            // button2_Gravar
            // 
            this.button2_Gravar.Location = new System.Drawing.Point(212, 216);
            this.button2_Gravar.Name = "button2_Gravar";
            this.button2_Gravar.Size = new System.Drawing.Size(75, 23);
            this.button2_Gravar.TabIndex = 13;
            this.button2_Gravar.Text = "Gravar";
            this.button2_Gravar.UseVisualStyleBackColor = true;
            this.button2_Gravar.Click += new System.EventHandler(this.button2_Gravar_Click);
            // 
            // button1_Limpar
            // 
            this.button1_Limpar.Location = new System.Drawing.Point(117, 216);
            this.button1_Limpar.Name = "button1_Limpar";
            this.button1_Limpar.Size = new System.Drawing.Size(75, 23);
            this.button1_Limpar.TabIndex = 12;
            this.button1_Limpar.Text = "Limpar";
            this.button1_Limpar.UseVisualStyleBackColor = true;
            this.button1_Limpar.Click += new System.EventHandler(this.button1_Limpar_Click);
            // 
            // textBox5_Email
            // 
            this.textBox5_Email.Enabled = false;
            this.textBox5_Email.Location = new System.Drawing.Point(117, 187);
            this.textBox5_Email.Name = "textBox5_Email";
            this.textBox5_Email.PlaceholderText = "Email do paciente";
            this.textBox5_Email.Size = new System.Drawing.Size(170, 23);
            this.textBox5_Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // textBox4_Paciente
            // 
            this.textBox4_Paciente.Enabled = false;
            this.textBox4_Paciente.Location = new System.Drawing.Point(117, 158);
            this.textBox4_Paciente.Name = "textBox4_Paciente";
            this.textBox4_Paciente.PlaceholderText = "Nome do paciente";
            this.textBox4_Paciente.Size = new System.Drawing.Size(170, 23);
            this.textBox4_Paciente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Paciente";
            // 
            // textBox3_IdPaciente
            // 
            this.textBox3_IdPaciente.Enabled = false;
            this.textBox3_IdPaciente.Location = new System.Drawing.Point(117, 126);
            this.textBox3_IdPaciente.Name = "textBox3_IdPaciente";
            this.textBox3_IdPaciente.PlaceholderText = "Id Paciente";
            this.textBox3_IdPaciente.Size = new System.Drawing.Size(105, 23);
            this.textBox3_IdPaciente.TabIndex = 7;
            // 
            // dateTimePicker1_DataMedicao
            // 
            this.dateTimePicker1_DataMedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_DataMedicao.Location = new System.Drawing.Point(117, 93);
            this.dateTimePicker1_DataMedicao.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1_DataMedicao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1_DataMedicao.Name = "dateTimePicker1_DataMedicao";
            this.dateTimePicker1_DataMedicao.Size = new System.Drawing.Size(105, 23);
            this.dateTimePicker1_DataMedicao.TabIndex = 6;
            // 
            // textBox2_ValorGlicemico
            // 
            this.textBox2_ValorGlicemico.Location = new System.Drawing.Point(117, 65);
            this.textBox2_ValorGlicemico.Name = "textBox2_ValorGlicemico";
            this.textBox2_ValorGlicemico.PlaceholderText = "Valor Glicemia";
            this.textBox2_ValorGlicemico.Size = new System.Drawing.Size(105, 23);
            this.textBox2_ValorGlicemico.TabIndex = 5;
            // 
            // textBox1_IdGlicemia
            // 
            this.textBox1_IdGlicemia.Location = new System.Drawing.Point(117, 32);
            this.textBox1_IdGlicemia.Name = "textBox1_IdGlicemia";
            this.textBox1_IdGlicemia.PlaceholderText = "Id Glicemia";
            this.textBox1_IdGlicemia.Size = new System.Drawing.Size(105, 23);
            this.textBox1_IdGlicemia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Medição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Glicemia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Glicemia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4_Editar);
            this.Controls.Add(this.button3_Deletar);
            this.Controls.Add(this.button2_Cadastrar);
            this.Controls.Add(this.button1_Conectar);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de medidas glicêmicas ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private Button button1_Conectar;
        private Button button2_Cadastrar;
        private Button button3_Deletar;
        private Button button4_Editar;
        private Panel panel1;
        private TextBox textBox2_ValorGlicemico;
        private TextBox textBox1_IdGlicemia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3_IdPaciente;
        private DateTimePicker dateTimePicker1_DataMedicao;
        private ColumnHeader IdMedida;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button2_Gravar;
        private Button button1_Limpar;
        private TextBox textBox5_Email;
        private Label label6;
        private TextBox textBox4_Paciente;
        private Label label5;
    }
}