namespace TerceiroExercicio
{
    partial class ConsultarCripto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_SiglaConsultar = new System.Windows.Forms.TextBox();
            this.button1_Consultar = new System.Windows.Forms.Button();
            this.textBox1_ExibeCripto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigla: ";
            // 
            // textBox1_SiglaConsultar
            // 
            this.textBox1_SiglaConsultar.Location = new System.Drawing.Point(67, 57);
            this.textBox1_SiglaConsultar.Name = "textBox1_SiglaConsultar";
            this.textBox1_SiglaConsultar.PlaceholderText = "Digite a sigla da criptomoeda";
            this.textBox1_SiglaConsultar.Size = new System.Drawing.Size(149, 23);
            this.textBox1_SiglaConsultar.TabIndex = 1;
            this.textBox1_SiglaConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_SiglaConsultar_KeyPress);
            // 
            // button1_Consultar
            // 
            this.button1_Consultar.Location = new System.Drawing.Point(67, 98);
            this.button1_Consultar.Name = "button1_Consultar";
            this.button1_Consultar.Size = new System.Drawing.Size(149, 27);
            this.button1_Consultar.TabIndex = 2;
            this.button1_Consultar.Text = "Consultar";
            this.button1_Consultar.UseVisualStyleBackColor = true;
            this.button1_Consultar.Click += new System.EventHandler(this.button1_Consultar_Click);
            // 
            // textBox1_ExibeCripto
            // 
            this.textBox1_ExibeCripto.Location = new System.Drawing.Point(67, 146);
            this.textBox1_ExibeCripto.Multiline = true;
            this.textBox1_ExibeCripto.Name = "textBox1_ExibeCripto";
            this.textBox1_ExibeCripto.ReadOnly = true;
            this.textBox1_ExibeCripto.Size = new System.Drawing.Size(149, 187);
            this.textBox1_ExibeCripto.TabIndex = 3;
            this.textBox1_ExibeCripto.TabStop = false;
            // 
            // ConsultarCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 345);
            this.Controls.Add(this.textBox1_ExibeCripto);
            this.Controls.Add(this.button1_Consultar);
            this.Controls.Add(this.textBox1_SiglaConsultar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Criptomoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1_SiglaConsultar;
        private Button button1_Consultar;
        private TextBox textBox1_ExibeCripto;
    }
}