namespace LoginUser
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
            this.label1_Login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Login
            // 
            this.label1_Login.AutoSize = true;
            this.label1_Login.Location = new System.Drawing.Point(12, 40);
            this.label1_Login.Name = "label1_Login";
            this.label1_Login.Size = new System.Drawing.Size(37, 15);
            this.label1_Login.TabIndex = 0;
            this.label1_Login.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Digite seu login";
            this.textBox1.Size = new System.Drawing.Size(228, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2_Senha
            // 
            this.textBox2_Senha.Location = new System.Drawing.Point(55, 66);
            this.textBox2_Senha.Name = "textBox2_Senha";
            this.textBox2_Senha.PlaceholderText = "Insira sua senha";
            this.textBox2_Senha.Size = new System.Drawing.Size(228, 23);
            this.textBox2_Senha.TabIndex = 2;
            this.textBox2_Senha.UseSystemPasswordChar = true;
            this.textBox2_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_Senha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // button1_Enviar
            // 
            this.button1_Enviar.Location = new System.Drawing.Point(55, 95);
            this.button1_Enviar.Name = "button1_Enviar";
            this.button1_Enviar.Size = new System.Drawing.Size(228, 37);
            this.button1_Enviar.TabIndex = 3;
            this.button1_Enviar.Text = "Enviar";
            this.button1_Enviar.UseVisualStyleBackColor = true;
            this.button1_Enviar.Click += new System.EventHandler(this.button1_Enviar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(223, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "             👀";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_Enviar);
            this.Controls.Add(this.textBox2_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_Login;
        private TextBox textBox1;
        private TextBox textBox2_Senha;
        private Label label1;
        private Button button1_Enviar;
        private Label label2;
    }
}