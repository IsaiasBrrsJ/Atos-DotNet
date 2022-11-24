namespace SerializaBinario
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
            this.txtSerializar = new System.Windows.Forms.TextBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDesserializar = new System.Windows.Forms.Button();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.btnDesJson = new System.Windows.Forms.Button();
            this.btnSerializaJson = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSerializar
            // 
            this.txtSerializar.Location = new System.Drawing.Point(12, 12);
            this.txtSerializar.Multiline = true;
            this.txtSerializar.Name = "txtSerializar";
            this.txtSerializar.PlaceholderText = "Digite seu texto aqui";
            this.txtSerializar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSerializar.Size = new System.Drawing.Size(219, 276);
            this.txtSerializar.TabIndex = 0;
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(12, 294);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(219, 47);
            this.btnSerializar.TabIndex = 1;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDesserializar
            // 
            this.btnDesserializar.Location = new System.Drawing.Point(12, 347);
            this.btnDesserializar.Name = "btnDesserializar";
            this.btnDesserializar.Size = new System.Drawing.Size(219, 47);
            this.btnDesserializar.TabIndex = 3;
            this.btnDesserializar.Text = "Desserializar";
            this.btnDesserializar.UseVisualStyleBackColor = true;
            this.btnDesserializar.Click += new System.EventHandler(this.btnDesserializar_Click);
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(237, 12);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ReadOnly = true;
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJson.Size = new System.Drawing.Size(246, 276);
            this.txtJson.TabIndex = 4;
            // 
            // btnDesJson
            // 
            this.btnDesJson.Location = new System.Drawing.Point(237, 347);
            this.btnDesJson.Name = "btnDesJson";
            this.btnDesJson.Size = new System.Drawing.Size(246, 47);
            this.btnDesJson.TabIndex = 6;
            this.btnDesJson.Text = "Desserializar Json";
            this.btnDesJson.UseVisualStyleBackColor = true;
            this.btnDesJson.Click += new System.EventHandler(this.btnDesJson_Click);
            // 
            // btnSerializaJson
            // 
            this.btnSerializaJson.Location = new System.Drawing.Point(237, 294);
            this.btnSerializaJson.Name = "btnSerializaJson";
            this.btnSerializaJson.Size = new System.Drawing.Size(246, 47);
            this.btnSerializaJson.TabIndex = 5;
            this.btnSerializaJson.Text = "Serializar Json";
            this.btnSerializaJson.UseVisualStyleBackColor = true;
            this.btnSerializaJson.Click += new System.EventHandler(this.btnSerializaJson_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(500, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 274);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 442);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDesJson);
            this.Controls.Add(this.btnSerializaJson);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.btnDesserializar);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.txtSerializar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serializa Bina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSerializar;
        private Button btnSerializar;
        private Button btnDesserializar;
        private TextBox txtJson;
        private Button btnDesJson;
        private Button btnSerializaJson;
        private ListBox listBox1;
    }
}