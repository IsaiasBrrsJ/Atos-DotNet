namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> liistaNomes = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_AdcionarLista_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }

        private void inserirTextBox_lista()
        {
            if (txt_NomeCompleto.Text == "")
            {
                MessageBox.Show("Para adcionar nome � preciso digitar algo", "ATEN��O");
            }
            else
            {
                //verificar se o nome j� existe

                if (liistaNomes.Contains(txt_NomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("Nome j� existente na lista", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    liistaNomes.Add(txt_NomeCompleto.Text.ToUpper());
                    liistaNomes.Sort();

                    //inserir o conte�do da lista ordenado
                    atualizarTextBoxLista(); 
                    txt_NomeCompleto.Clear();
                }
            }

            txt_NomeCompleto.Focus();
        }

        private void atualizarTextBoxLista()
        {
            textBox1_listPessoa.Text = String.Empty;
        
            foreach (var item in liistaNomes)
            {
                textBox1_listPessoa.Text += item + Environment.NewLine;
            }
        }

        private void txt_NomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
               button1_AdcionarLista.PerformClick(); //chama o button de click
            }
        }



      
    }
}