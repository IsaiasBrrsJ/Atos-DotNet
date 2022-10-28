using PrimeiraAtividade.Classe;
using System.Reflection.Metadata.Ecma335;

namespace PrimeiraAtividade
{
    public partial class Form1 : Form
    {   


        public Form1()
        {
            InitializeComponent();
            
        }
        string email = "";
        string dominio = "";

        List<Email> listEmail = new List<Email>();

     

        private void textBox2_email_KeyPress(object sender, KeyPressEventArgs e)
        {
             email = textBox2_email.Text;
          
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((!String.IsNullOrWhiteSpace(email) && email.Contains("@")) && !email.StartsWith("@"))
                {
                    button1_Cadastrar.Enabled = true;
                    button1_Cadastrar.Focus();
                }
                else
                {
                  
                    MessageBox.Show("Preencha o E-mail Corretamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                     textBox2_email.Focus();
                    
                }

                e.Handled = true;

            }
        }

        private bool VerificaEmail()
        {
            if (listEmail.Count > 0)
            {
                foreach (var item in listEmail)
                {
                    if (item.getEmail() == email)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private string PegaDominio()
        {
            dominio = email.Substring(email.IndexOf("@"));
           
            return dominio;
        }
        private void button1_Cadastrar_Click(object sender, EventArgs e)
        {
            if (VerificaEmail())
            {
                MessageBox.Show("E-mail, já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                listEmail.Add(new Email(email: email.ToLower(), dominio: PegaDominio().ToLower()));

                

                MessageBox.Show("Cadastrado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                button2_ExibirEmailDominio.Enabled = true;
            }

            

            button3_LimparCampos.PerformClick();
            textBox2_email.Focus();
        }

        private void button3_LimparCampos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2_email.Text)) { MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                textBox2_email.Text = String.Empty;
                button1_Cadastrar.Enabled = false;
            }



        }

        private void button2_ExibirEmailDominio_Click(object sender, EventArgs e)
        {
            textBox1_ListaDeEmail.Text = String.Empty;
            textBox_ListaDominios.Text = String.Empty;

            listEmail.Sort((e, e1) => e.getEmail().CompareTo(e1.getEmail()));


            foreach (var item in listEmail)
            {   
              
                textBox1_ListaDeEmail.Text += item.getEmail() + Environment.NewLine;
                textBox_ListaDominios.Text += item.getDominio() + Environment.NewLine;
            }
        }
    }
}   