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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_NomeCompleto = new System.Windows.Forms.TextBox();
            this.textBox2_ListNomes = new System.Windows.Forms.TextBox();
            this.button1_Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // textBox1_NomeCompleto
            // 
            this.textBox1_NomeCompleto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1_NomeCompleto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1_NomeCompleto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1_NomeCompleto.Location = new System.Drawing.Point(12, 96);
            this.textBox1_NomeCompleto.Name = "textBox1_NomeCompleto";
            this.textBox1_NomeCompleto.Size = new System.Drawing.Size(277, 33);
            this.textBox1_NomeCompleto.TabIndex = 1;
            this.textBox1_NomeCompleto.TextChanged += new System.EventHandler(this.textBox1_NomeCompleto_TextChanged);
            this.textBox1_NomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_NomeCompleto_KeyPress);
            // 
            // textBox2_ListNomes
            // 
            this.textBox2_ListNomes.Location = new System.Drawing.Point(12, 181);
            this.textBox2_ListNomes.Multiline = true;
            this.textBox2_ListNomes.Name = "textBox2_ListNomes";
            this.textBox2_ListNomes.ReadOnly = true;
            this.textBox2_ListNomes.Size = new System.Drawing.Size(277, 239);
            this.textBox2_ListNomes.TabIndex = 2;
            // 
            // button1_Enviar
            // 
            this.button1_Enviar.Location = new System.Drawing.Point(12, 135);
            this.button1_Enviar.Name = "button1_Enviar";
            this.button1_Enviar.Size = new System.Drawing.Size(277, 36);
            this.button1_Enviar.TabIndex = 3;
            this.button1_Enviar.Text = "Enviar";
            this.button1_Enviar.UseVisualStyleBackColor = true;
            this.button1_Enviar.Click += new System.EventHandler(this.button1_Enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 432);
            this.Controls.Add(this.button1_Enviar);
            this.Controls.Add(this.textBox2_ListNomes);
            this.Controls.Add(this.textBox1_NomeCompleto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastra Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1_NomeCompleto;
        private TextBox textBox2_ListNomes;
        private Button button1_Enviar;
    }
}