using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerceiroExercicio.classes;

namespace TerceiroExercicio
{
    public partial class CadastroCripto : Form
    {
        List<Criptomoeda> cripto;
        public double valorCripto = 0;
        public string nomeCripto = "";
        public string siglaCripto = "";
        public CadastroCripto(ref List<Criptomoeda> cripto)
        {
            this.cripto = cripto;
            InitializeComponent();
        }
        private void button1_Cadastrar_Click(object sender, EventArgs e)
        {
         
            if (String.IsNullOrWhiteSpace(textBox1_NomeCripto.Text) || String.IsNullOrWhiteSpace(textBox2_SiglaCripto.Text) || String.IsNullOrWhiteSpace(textBox1_Valor.Text)
               || (double.TryParse(textBox1_Valor.Text, out valorCripto) == false))
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (jaEstaCadastrado())
            {
                MessageBox.Show($"Cripot: [{textBox2_SiglaCripto.Text}], já consta no cadastro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   

                MessageBox.Show("Cripto cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valorCripto = Convert.ToDouble(textBox1_Valor.Text);
                nomeCripto = textBox1_NomeCripto.Text;
                siglaCripto = textBox2_SiglaCripto.Text;

                cripto.Add(new Criptomoeda(nomeCripto, siglaCripto, valorCripto));

 
                LimpaCampos();
            }
        }
        private bool jaEstaCadastrado()
        {
            foreach (var cript in cripto)
            {
                if(cript.getSiglaCripto() == textBox2_SiglaCripto.Text)
                {
                    return true;
                } 
            }
            return false;
        }
        private void textBox1_NomeCripto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Cadastrar.PerformClick();
            }
        }
        private void textBox2_SiglaCripto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Cadastrar.PerformClick();
            }
        }

        private void textBox1_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Cadastrar.PerformClick();
            }
        }
        private void LimpaCampos()
        {
            textBox1_NomeCripto.Text = String.Empty;
            textBox1_Valor.Text = String.Empty;
            textBox2_SiglaCripto.Text = String.Empty;
            textBox1_NomeCripto.Focus();
        }

        private void CadastroCripto_Load(object sender, EventArgs e)
        {

        }
    }
}
