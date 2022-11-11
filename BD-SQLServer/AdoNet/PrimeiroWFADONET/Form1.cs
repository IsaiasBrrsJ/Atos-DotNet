using WinFormsADONet;

namespace PrimeiroWFADONET
{
    public partial class Form1 : Form
    {
        Banco banco;
        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
        }

        private void button1_ConectaBanco_Click(object sender, EventArgs e)
        {
         
          
            Empregado departamentoEmpregado = new Empregado();
           
            if (departamentoEmpregado.GravaFuncionario())
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar Empregado", "Aviso");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}