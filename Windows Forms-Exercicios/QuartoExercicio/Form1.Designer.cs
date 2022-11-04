namespace QuartoExercicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_NomeJogador = new System.Windows.Forms.TextBox();
            this.button1_Gravar = new System.Windows.Forms.Button();
            this.button2_Limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_ListJogadores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Jogador:";
            // 
            // textBox1_NomeJogador
            // 
            this.textBox1_NomeJogador.Location = new System.Drawing.Point(130, 26);
            this.textBox1_NomeJogador.Name = "textBox1_NomeJogador";
            this.textBox1_NomeJogador.PlaceholderText = "            → Digite seu nome completo ←";
            this.textBox1_NomeJogador.Size = new System.Drawing.Size(262, 23);
            this.textBox1_NomeJogador.TabIndex = 1;
          
            this.textBox1_NomeJogador.TextChanged += new System.EventHandler(this.textBox1_NomeJogador_TextChanged);
            this.textBox1_NomeJogador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_NomeJogador_KeyPress);
            // 
            // button1_Gravar
            // 
            this.button1_Gravar.Enabled = false;
            this.button1_Gravar.Location = new System.Drawing.Point(12, 65);
            this.button1_Gravar.Name = "button1_Gravar";
            this.button1_Gravar.Size = new System.Drawing.Size(75, 23);
            this.button1_Gravar.TabIndex = 2;
            this.button1_Gravar.Text = "Gravar";
            this.button1_Gravar.UseVisualStyleBackColor = true;
            this.button1_Gravar.Click += new System.EventHandler(this.button1_Gravar_Click);
            // 
            // button2_Limpar
            // 
            this.button2_Limpar.Location = new System.Drawing.Point(93, 65);
            this.button2_Limpar.Name = "button2_Limpar";
            this.button2_Limpar.Size = new System.Drawing.Size(75, 23);
            this.button2_Limpar.TabIndex = 3;
            this.button2_Limpar.Text = "Limpar";
            this.button2_Limpar.UseVisualStyleBackColor = true;
            this.button2_Limpar.Click += new System.EventHandler(this.button2_Limpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de jogadores cadastrados📝";
            // 
            // textBox1_ListJogadores
            // 
            this.textBox1_ListJogadores.Location = new System.Drawing.Point(192, 65);
            this.textBox1_ListJogadores.Multiline = true;
            this.textBox1_ListJogadores.Name = "textBox1_ListJogadores";
            this.textBox1_ListJogadores.ReadOnly = true;
            this.textBox1_ListJogadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_ListJogadores.Size = new System.Drawing.Size(475, 191);
            this.textBox1_ListJogadores.TabIndex = 5;
            this.textBox1_ListJogadores.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 268);
            this.Controls.Add(this.textBox1_ListJogadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_Limpar);
            this.Controls.Add(this.button1_Gravar);
            this.Controls.Add(this.textBox1_NomeJogador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1_NomeJogador;
        private Button button1_Gravar;
        private Button button2_Limpar;
        private Label label2;
        private TextBox textBox1_ListJogadores;
    }
}