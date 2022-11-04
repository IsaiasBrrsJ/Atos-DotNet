namespace TerceiroExercicio
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
            this.comboBox1_ListOpcoes = new System.Windows.Forms.ComboBox();
            this.button1_Menu_Ir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Cripto";
            // 
            // comboBox1_ListOpcoes
            // 
            this.comboBox1_ListOpcoes.FormattingEnabled = true;
            this.comboBox1_ListOpcoes.Items.AddRange(new object[] {
            "Cadastrar Cripto",
            "Consultar Cripto",
            "Remover Cripto",
            "Listar Criptos"});
            this.comboBox1_ListOpcoes.Location = new System.Drawing.Point(33, 101);
            this.comboBox1_ListOpcoes.Name = "comboBox1_ListOpcoes";
            this.comboBox1_ListOpcoes.Size = new System.Drawing.Size(206, 23);
            this.comboBox1_ListOpcoes.TabIndex = 2;
            this.comboBox1_ListOpcoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_ListOpcoes_KeyPress);
            // 
            // button1_Menu_Ir
            // 
            this.button1_Menu_Ir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1_Menu_Ir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1_Menu_Ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Menu_Ir.Location = new System.Drawing.Point(33, 225);
            this.button1_Menu_Ir.Name = "button1_Menu_Ir";
            this.button1_Menu_Ir.Size = new System.Drawing.Size(206, 27);
            this.button1_Menu_Ir.TabIndex = 3;
            this.button1_Menu_Ir.Text = "Ir";
            this.button1_Menu_Ir.UseVisualStyleBackColor = true;
            this.button1_Menu_Ir.Click += new System.EventHandler(this.button1_Menu_Ir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 264);
            this.Controls.Add(this.button1_Menu_Ir);
            this.Controls.Add(this.comboBox1_ListOpcoes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cripto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox1_ListOpcoes;
        private Button button1_Menu_Ir;
    }
}