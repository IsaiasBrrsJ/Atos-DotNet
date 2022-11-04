namespace TerceiroExercicio
{
    partial class RemoverCripto
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
            this.textBox1_SiglaRemover = new System.Windows.Forms.TextBox();
            this.button1_RemoverCripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigla";
            // 
            // textBox1_SiglaRemover
            // 
            this.textBox1_SiglaRemover.Location = new System.Drawing.Point(45, 51);
            this.textBox1_SiglaRemover.Name = "textBox1_SiglaRemover";
            this.textBox1_SiglaRemover.PlaceholderText = " Digite a sigla da criptomoeda";
            this.textBox1_SiglaRemover.Size = new System.Drawing.Size(188, 23);
            this.textBox1_SiglaRemover.TabIndex = 1;
            this.textBox1_SiglaRemover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_SiglaRemover_KeyPress);
            // 
            // button1_RemoverCripto
            // 
            this.button1_RemoverCripto.Location = new System.Drawing.Point(45, 89);
            this.button1_RemoverCripto.Name = "button1_RemoverCripto";
            this.button1_RemoverCripto.Size = new System.Drawing.Size(188, 29);
            this.button1_RemoverCripto.TabIndex = 2;
            this.button1_RemoverCripto.Text = "Remover";
            this.button1_RemoverCripto.UseVisualStyleBackColor = true;
            this.button1_RemoverCripto.Click += new System.EventHandler(this.button1_RemoverCripto_Click);
            // 
            // RemoverCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 212);
            this.Controls.Add(this.button1_RemoverCripto);
            this.Controls.Add(this.textBox1_SiglaRemover);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoverCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover Cripto";
            this.Load += new System.EventHandler(this.RemoverCripto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1_SiglaRemover;
        private Button button1_RemoverCripto;
    }
}