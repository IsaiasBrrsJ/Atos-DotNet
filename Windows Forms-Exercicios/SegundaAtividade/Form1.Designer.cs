namespace PrimeiraAtividade
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
            this.label2_Email = new System.Windows.Forms.Label();
            this.textBox2_email = new System.Windows.Forms.TextBox();
            this.button1_Cadastrar = new System.Windows.Forms.Button();
            this.button2_ExibirEmailDominio = new System.Windows.Forms.Button();
            this.textBox1_ListaDeEmail = new System.Windows.Forms.TextBox();
            this.textBox_ListaDominios = new System.Windows.Forms.TextBox();
            this.button3_LimparCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2_Email
            // 
            this.label2_Email.AutoSize = true;
            this.label2_Email.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2_Email.Location = new System.Drawing.Point(24, 67);
            this.label2_Email.Name = "label2_Email";
            this.label2_Email.Size = new System.Drawing.Size(58, 21);
            this.label2_Email.TabIndex = 1;
            this.label2_Email.Text = "E-mail:";
            // 
            // textBox2_email
            // 
            this.textBox2_email.Location = new System.Drawing.Point(88, 67);
            this.textBox2_email.Name = "textBox2_email";
            this.textBox2_email.Size = new System.Drawing.Size(281, 23);
            this.textBox2_email.TabIndex = 2;
            this.textBox2_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_email_KeyPress);
            // 
            // button1_Cadastrar
            // 
            this.button1_Cadastrar.Enabled = false;
            this.button1_Cadastrar.Location = new System.Drawing.Point(24, 119);
            this.button1_Cadastrar.Name = "button1_Cadastrar";
            this.button1_Cadastrar.Size = new System.Drawing.Size(112, 36);
            this.button1_Cadastrar.TabIndex = 3;
            this.button1_Cadastrar.Text = "Cadastrar";
            this.button1_Cadastrar.UseVisualStyleBackColor = true;
            this.button1_Cadastrar.Click += new System.EventHandler(this.button1_Cadastrar_Click);
            // 
            // button2_ExibirEmailDominio
            // 
            this.button2_ExibirEmailDominio.Enabled = false;
            this.button2_ExibirEmailDominio.Location = new System.Drawing.Point(142, 119);
            this.button2_ExibirEmailDominio.Name = "button2_ExibirEmailDominio";
            this.button2_ExibirEmailDominio.Size = new System.Drawing.Size(105, 36);
            this.button2_ExibirEmailDominio.TabIndex = 4;
            this.button2_ExibirEmailDominio.Text = "Exibir E-mails";
            this.button2_ExibirEmailDominio.UseVisualStyleBackColor = true;
            this.button2_ExibirEmailDominio.Click += new System.EventHandler(this.button2_ExibirEmailDominio_Click);
            // 
            // textBox1_ListaDeEmail
            // 
            this.textBox1_ListaDeEmail.Location = new System.Drawing.Point(24, 161);
            this.textBox1_ListaDeEmail.Multiline = true;
            this.textBox1_ListaDeEmail.Name = "textBox1_ListaDeEmail";
            this.textBox1_ListaDeEmail.ReadOnly = true;
            this.textBox1_ListaDeEmail.Size = new System.Drawing.Size(170, 260);
            this.textBox1_ListaDeEmail.TabIndex = 4;
            this.textBox1_ListaDeEmail.TabStop = false;
            // 
            // textBox_ListaDominios
            // 
            this.textBox_ListaDominios.Location = new System.Drawing.Point(200, 161);
            this.textBox_ListaDominios.Multiline = true;
            this.textBox_ListaDominios.Name = "textBox_ListaDominios";
            this.textBox_ListaDominios.ReadOnly = true;
            this.textBox_ListaDominios.Size = new System.Drawing.Size(170, 260);
            this.textBox_ListaDominios.TabIndex = 5;
            this.textBox_ListaDominios.TabStop = false;
            // 
            // button3_LimparCampos
            // 
            this.button3_LimparCampos.Location = new System.Drawing.Point(252, 119);
            this.button3_LimparCampos.Name = "button3_LimparCampos";
            this.button3_LimparCampos.Size = new System.Drawing.Size(118, 36);
            this.button3_LimparCampos.TabIndex = 6;
            this.button3_LimparCampos.Text = "Limpar Campos";
            this.button3_LimparCampos.UseVisualStyleBackColor = true;
            this.button3_LimparCampos.Click += new System.EventHandler(this.button3_LimparCampos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 462);
            this.Controls.Add(this.button3_LimparCampos);
            this.Controls.Add(this.textBox_ListaDominios);
            this.Controls.Add(this.textBox1_ListaDeEmail);
            this.Controls.Add(this.button2_ExibirEmailDominio);
            this.Controls.Add(this.button1_Cadastrar);
            this.Controls.Add(this.textBox2_email);
            this.Controls.Add(this.label2_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2_Email;
        private TextBox textBox2_email;
        private Button button1_Cadastrar;
        private Button button2_ExibirEmailDominio;
        private TextBox textBox1_ListaDeEmail;
        private TextBox textBox_ListaDominios;
        private Button button3_LimparCampos;
    }
}