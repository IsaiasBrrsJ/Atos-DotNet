namespace TerceiroExercicio
{
    partial class ListarCriptos
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
            this.textBox1_ListCriptomoedas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_ListCriptomoedas
            // 
            this.textBox1_ListCriptomoedas.Location = new System.Drawing.Point(12, 59);
            this.textBox1_ListCriptomoedas.Multiline = true;
            this.textBox1_ListCriptomoedas.Name = "textBox1_ListCriptomoedas";
            this.textBox1_ListCriptomoedas.ReadOnly = true;
            this.textBox1_ListCriptomoedas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_ListCriptomoedas.Size = new System.Drawing.Size(337, 355);
            this.textBox1_ListCriptomoedas.TabIndex = 0;
            // 
            // ListarCriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.textBox1_ListCriptomoedas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListarCriptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Criptomoedas";
            this.Load += new System.EventHandler(this.ListarCriptos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1_ListCriptomoedas;
    }
}