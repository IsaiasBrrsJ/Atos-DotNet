using QuartoExercicio.Classe;

namespace QuartoExercicio
{
    public partial class Form1 : Form
    {
        List<Jogador> jogadorList;
        public Form1()
        {
            InitializeComponent();
            Util.LerBaseDeDados();
            jogadorList = new List<Jogador>(Util.RetornarJogador());
            AdcionaNaTextBoxList();
        }
        private void button1_Gravar_Click(object sender, EventArgs e)
        {
            string nomeJogador = textBox1_NomeJogador.Text.TrimEnd(' ');
            if (Util.jaEstaCadastrado(nomeJogador))
            {
                MessageBox.Show("Nome já cadastrado", "Aviso");
            }
            else
            {
                Util.GerarEmailJogador(nomeJogador);
                Util.GravaNoArquivo();

                MessageBox.Show("Cadastrado com Sucesso", "Sucesso");
                AdcionaNaTextBoxList();
            }
        }

        private void button2_Limpar_Click(object sender, EventArgs e)
        {
            jogadorList.Clear();
            textBox1_ListJogadores.Text = String.Empty;
        }
        private void AdcionaNaTextBoxList()
        {
            textBox1_ListJogadores.Text = String.Empty;

            foreach (var item in Util.RetornarJogador())
            {
                textBox1_ListJogadores.Text += $"{item.getNomeJogador()} - {item.getEmailJogador()}" + Environment.NewLine;
            }
        }

        private void textBox1_NomeJogador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && button1_Gravar.Enabled == false)
            {
                MessageBox.Show("Preencha seu corretamente, obs..: Completo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1_Gravar.PerformClick();
            }
        }

        private void textBox1_NomeJogador_TextChanged(object sender, EventArgs e)
        {
            // verifica se o nome é completo

            string nomeJogador = textBox1_NomeJogador.Text;

            if (nomeJogador.Split(' ').Length >= 2 && (!String.IsNullOrWhiteSpace(nomeJogador.Split(' ')[1]) && VerificarSeExisteNumeroNoNome() == false))
            {
                button1_Gravar.Enabled = true;
            }
            else
            {
                button1_Gravar.Enabled = false;
            }
        }

        private bool VerificarSeExisteNumeroNoNome()
        {

            for (int i = 0; i < textBox1_NomeJogador.Text.Length; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (textBox1_NomeJogador.Text[i].ToString() == j.ToString())
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}