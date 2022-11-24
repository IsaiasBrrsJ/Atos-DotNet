namespace DepartamentoEmpreagoBD
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
            this.comboBox1_menuOpc = new System.Windows.Forms.ComboBox();
            this.button1_Ir = new System.Windows.Forms.Button();
            this.label1_Hora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1_menuOpc
            // 
            this.comboBox1_menuOpc.FormattingEnabled = true;
            this.comboBox1_menuOpc.Items.AddRange(new object[] {
            "Selecione",
            "Departamento",
            "Empregado"});
            this.comboBox1_menuOpc.Location = new System.Drawing.Point(49, 67);
            this.comboBox1_menuOpc.Name = "comboBox1_menuOpc";
            this.comboBox1_menuOpc.Size = new System.Drawing.Size(184, 23);
            this.comboBox1_menuOpc.TabIndex = 0;
            // 
            // button1_Ir
            // 
            this.button1_Ir.Location = new System.Drawing.Point(59, 128);
            this.button1_Ir.Name = "button1_Ir";
            this.button1_Ir.Size = new System.Drawing.Size(174, 36);
            this.button1_Ir.TabIndex = 1;
            this.button1_Ir.Text = "Ir";
            this.button1_Ir.UseVisualStyleBackColor = true;
            // 
            // label1_Hora
            // 
            this.label1_Hora.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_Hora.Location = new System.Drawing.Point(108, 31);
            this.label1_Hora.Name = "label1_Hora";
            this.label1_Hora.Size = new System.Drawing.Size(106, 21);
            this.label1_Hora.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 195);
            this.Controls.Add(this.label1_Hora);
            this.Controls.Add(this.button1_Ir);
            this.Controls.Add(this.comboBox1_menuOpc);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1_menuOpc;
        private Button button1_Ir;
        private Label label1_Hora;
    }
}