using PrimeiraAtividade.Classes;

namespace PrimeiraAtividade
{
    public partial class Form1 : Form
    {
        List<Pessoa> listPessoa = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Enviar_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(textBox1_NomeCompleto.Text) || textBox1_NomeCompleto.Text.Split(" ").Length < 2) || textBox1_NomeCompleto.Text.StartsWith(" "))
            {
                MessageBox.Show("Preencha o nome corretamente, 'Completo'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (VerificaNome())
            {
                MessageBox.Show("Nome já foi cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listPessoa.Add(new Pessoa() { Nome = textBox1_NomeCompleto.Text });
                textBox1_NomeCompleto.Text = String.Empty;
                listPessoa.Sort((p, p1) => p.Nome.CompareTo(p1.Nome));

                AdcionaNaListaVisual();
            }

            textBox1_NomeCompleto.Text = String.Empty;

        }
        private void AdcionaNaListaVisual()
        {
            textBox2_ListNomes.Text = String.Empty;
            foreach (var item in listPessoa)
            {
                textBox2_ListNomes.Text += item.Nome + Environment.NewLine;
            }
        }
        private void textBox1_NomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Enviar.PerformClick();
                e.Handled = true;
            }
        }

        private bool VerificaNome()
        {

            foreach (var item in listPessoa)
            {
                if (item.Nome == textBox1_NomeCompleto.Text.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }


        private void textBox1_NomeCompleto_TextChanged(object sender, EventArgs e)
        {
           

         var texto = textBox1_NomeCompleto.Text.ToUpper();// jogo o texto em uma string
         textBox1_NomeCompleto.Text = texto.ToString(); // adiona no text box
         textBox1_NomeCompleto.Select(texto.Length, 0); // pego o proximo caractere


        }
    }
}