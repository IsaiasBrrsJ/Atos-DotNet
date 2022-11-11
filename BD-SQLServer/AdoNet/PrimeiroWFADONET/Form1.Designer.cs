namespace PrimeiroWFADONET
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
            this.button1_ConectaBanco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_NomeDept = new System.Windows.Forms.TextBox();
            this.textBox2_DepLoca = new System.Windows.Forms.TextBox();
            this.textBox3_Orca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_ConectaBanco
            // 
            this.button1_ConectaBanco.Location = new System.Drawing.Point(129, 205);
            this.button1_ConectaBanco.Name = "button1_ConectaBanco";
            this.button1_ConectaBanco.Size = new System.Drawing.Size(134, 36);
            this.button1_ConectaBanco.TabIndex = 0;
            this.button1_ConectaBanco.Text = "Salvar";
            this.button1_ConectaBanco.UseVisualStyleBackColor = true;
            this.button1_ConectaBanco.Click += new System.EventHandler(this.button1_ConectaBanco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "NomeDept";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "localizacaoDep";
            // 
            // textBox1_NomeDept
            // 
            this.textBox1_NomeDept.Location = new System.Drawing.Point(129, 29);
            this.textBox1_NomeDept.Name = "textBox1_NomeDept";
            this.textBox1_NomeDept.Size = new System.Drawing.Size(168, 23);
            this.textBox1_NomeDept.TabIndex = 3;
            // 
            // textBox2_DepLoca
            // 
            this.textBox2_DepLoca.Location = new System.Drawing.Point(129, 58);
            this.textBox2_DepLoca.Name = "textBox2_DepLoca";
            this.textBox2_DepLoca.Size = new System.Drawing.Size(168, 23);
            this.textBox2_DepLoca.TabIndex = 4;
            // 
            // textBox3_Orca
            // 
            this.textBox3_Orca.Location = new System.Drawing.Point(129, 87);
            this.textBox3_Orca.Name = "textBox3_Orca";
            this.textBox3_Orca.Size = new System.Drawing.Size(168, 23);
            this.textBox3_Orca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ORca";
            // 
            // textBox1_Id
            // 
            this.textBox1_Id.Location = new System.Drawing.Point(129, 0);
            this.textBox1_Id.Name = "textBox1_Id";
            this.textBox1_Id.Size = new System.Drawing.Size(168, 23);
            this.textBox1_Id.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.textBox1_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3_Orca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_DepLoca);
            this.Controls.Add(this.textBox1_NomeDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_ConectaBanco);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar com Banco de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_ConectaBanco;
        private Label label1;
        private Label label2;
        private TextBox textBox1_NomeDept;
        private TextBox textBox2_DepLoca;
        private TextBox textBox3_Orca;
        private Label label3;
        private TextBox textBox1_Id;
        private Label label4;
    }
}