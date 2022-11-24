namespace Exec001
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataTxt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnSoap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite seu nome";
            this.txtNome.Size = new System.Drawing.Size(230, 23);
            this.txtNome.TabIndex = 0;
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(78, 81);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(230, 23);
            this.dataTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Nasc";
            // 
            // maskTxtCpf
            // 
            this.maskTxtCpf.Location = new System.Drawing.Point(78, 119);
            this.maskTxtCpf.Mask = "000.000.000-00";
            this.maskTxtCpf.Name = "maskTxtCpf";
            this.maskTxtCpf.Size = new System.Drawing.Size(230, 23);
            this.maskTxtCpf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(78, 157);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(230, 33);
            this.btnJson.TabIndex = 6;
            this.btnJson.Text = "Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(78, 235);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(230, 33);
            this.btnXml.TabIndex = 7;
            this.btnXml.Text = "Xml";
            this.btnXml.UseVisualStyleBackColor = true;
            // 
            // btnSoap
            // 
            this.btnSoap.Location = new System.Drawing.Point(78, 196);
            this.btnSoap.Name = "btnSoap";
            this.btnSoap.Size = new System.Drawing.Size(230, 33);
            this.btnSoap.TabIndex = 8;
            this.btnSoap.Text = "Soap";
            this.btnSoap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 282);
            this.Controls.Add(this.btnSoap);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskTxtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serializa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private DateTimePicker dataTxt;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskTxtCpf;
        private Label label3;
        private Button btnJson;
        private Button btnXml;
        private Button btnSoap;
    }
}