namespace LoginUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            textBox2_Senha.UseSystemPasswordChar = false;
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            textBox2_Senha.UseSystemPasswordChar = true;
        }

        private void textBox2_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Enviar.PerformClick();

                e.Handled = true;
            }
            
        }

        private void button1_Enviar_Click(object sender, EventArgs e)
        {
            var gravarNoBanco = new Gravar();

            var login = textBox1.Text;
            var password = textBox2_Senha.Text;

            var sucess = gravarNoBanco.WriteInDatabase(login, password);

            if (sucess)
            {
                MessageBox.Show("Dados gravados com sucesso");
            }
            else
            {
                MessageBox.Show("Erro no banco");
            }
        }
    }
}