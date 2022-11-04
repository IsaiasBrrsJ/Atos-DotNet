namespace TerceiroExercicio
{
    partial class CadastroCripto
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
            this.label1_NomeCripto = new System.Windows.Forms.Label();
            this.label1_Apresentacao = new System.Windows.Forms.Label();
            this.textBox1_NomeCripto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2_SiglaCripto = new System.Windows.Forms.TextBox();
            this.button1_Cadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_Valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1_NomeCripto
            // 
            this.label1_NomeCripto.AutoSize = true;
            this.label1_NomeCripto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_NomeCripto.Location = new System.Drawing.Point(3, 58);
            this.label1_NomeCripto.Name = "label1_NomeCripto";
            this.label1_NomeCripto.Size = new System.Drawing.Size(60, 21);
            this.label1_NomeCripto.TabIndex = 1;
            this.label1_NomeCripto.Text = "Nome: ";
            // 
            // label1_Apresentacao
            // 
            this.label1_Apresentacao.AutoSize = true;
            this.label1_Apresentacao.Location = new System.Drawing.Point(125, 19);
            this.label1_Apresentacao.Name = "label1_Apresentacao";
            this.label1_Apresentacao.Size = new System.Drawing.Size(104, 15);
            this.label1_Apresentacao.TabIndex = 2;
            this.label1_Apresentacao.Text = "Cadastro de cripto";
            // 
            // textBox1_NomeCripto
            // 
            this.textBox1_NomeCripto.Location = new System.Drawing.Point(73, 63);
            this.textBox1_NomeCripto.Name = "textBox1_NomeCripto";
            this.textBox1_NomeCripto.PlaceholderText = "Digite o nome da criptomoeda";
            this.textBox1_NomeCripto.Size = new System.Drawing.Size(255, 23);
            this.textBox1_NomeCripto.TabIndex = 1;
            this.textBox1_NomeCripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_NomeCripto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sigla: ";
            // 
            // textBox2_SiglaCripto
            // 
            this.textBox2_SiglaCripto.Location = new System.Drawing.Point(73, 115);
            this.textBox2_SiglaCripto.Name = "textBox2_SiglaCripto";
            this.textBox2_SiglaCripto.PlaceholderText = "Digite a sigla da criptomoeda";
            this.textBox2_SiglaCripto.Size = new System.Drawing.Size(255, 23);
            this.textBox2_SiglaCripto.TabIndex = 2;
            this.textBox2_SiglaCripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_SiglaCripto_KeyPress);
            // 
            // button1_Cadastrar
            // 
            this.button1_Cadastrar.Location = new System.Drawing.Point(57, 217);
            this.button1_Cadastrar.Name = "button1_Cadastrar";
            this.button1_Cadastrar.Size = new System.Drawing.Size(271, 35);
            this.button1_Cadastrar.TabIndex = 4;
            this.button1_Cadastrar.Text = "Cadastrar";
            this.button1_Cadastrar.UseVisualStyleBackColor = true;
            this.button1_Cadastrar.Click += new System.EventHandler(this.button1_Cadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor R$:";
            // 
            // textBox1_Valor
            // 
            this.textBox1_Valor.Location = new System.Drawing.Point(73, 168);
            this.textBox1_Valor.Name = "textBox1_Valor";
            this.textBox1_Valor.PlaceholderText = "Digite o valor da criptomoeda";
            this.textBox1_Valor.Size = new System.Drawing.Size(255, 23);
            this.textBox1_Valor.TabIndex = 3;
            this.textBox1_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_Valor_KeyPress);
            // 
            // CadastroCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 267);
            this.Controls.Add(this.textBox1_Valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_Cadastrar);
            this.Controls.Add(this.textBox2_SiglaCripto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_NomeCripto);
            this.Controls.Add(this.label1_Apresentacao);
            this.Controls.Add(this.label1_NomeCripto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Criptomoeda";
            this.Load += new System.EventHandler(this.CadastroCripto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1_NomeCripto;
        private Label label1_Apresentacao;
        private TextBox textBox1_NomeCripto;
        private Label label1;
        private TextBox textBox2_SiglaCripto;
        private Button button1_Cadastrar;
        private Label label2;
        private TextBox textBox1_Valor;
    }
}