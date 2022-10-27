namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NomeCompleto = new System.Windows.Forms.TextBox();
            this.button1_AdcionarLista = new System.Windows.Forms.Button();
            this.textBox1_listPessoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // txt_NomeCompleto
            // 
            this.txt_NomeCompleto.Location = new System.Drawing.Point(114, 6);
            this.txt_NomeCompleto.Name = "txt_NomeCompleto";
            this.txt_NomeCompleto.Size = new System.Drawing.Size(227, 23);
            this.txt_NomeCompleto.TabIndex = 1;
            this.txt_NomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeCompleto_KeyPress);
            // 
            // button1_AdcionarLista
            // 
            this.button1_AdcionarLista.Location = new System.Drawing.Point(114, 35);
            this.button1_AdcionarLista.Name = "button1_AdcionarLista";
            this.button1_AdcionarLista.Size = new System.Drawing.Size(105, 30);
            this.button1_AdcionarLista.TabIndex = 2;
            this.button1_AdcionarLista.Text = "Inserir";
            this.button1_AdcionarLista.UseVisualStyleBackColor = true;
            this.button1_AdcionarLista.Click += new System.EventHandler(this.button1_AdcionarLista_Click);
            // 
            // textBox1_listPessoa
            // 
            this.textBox1_listPessoa.Location = new System.Drawing.Point(114, 71);
            this.textBox1_listPessoa.Multiline = true;
            this.textBox1_listPessoa.Name = "textBox1_listPessoa";
            this.textBox1_listPessoa.ReadOnly = true;
            this.textBox1_listPessoa.Size = new System.Drawing.Size(227, 260);
            this.textBox1_listPessoa.TabIndex = 0;
            this.textBox1_listPessoa.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_listPessoa);
            this.Controls.Add(this.button1_AdcionarLista);
            this.Controls.Add(this.txt_NomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Titulo do formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_NomeCompleto;
        private Button button1_AdcionarLista;
        private TextBox textBox1_listPessoa;
        private Button button1;
    }
}