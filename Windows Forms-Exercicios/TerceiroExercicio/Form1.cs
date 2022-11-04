using TerceiroExercicio.classes;

namespace TerceiroExercicio
{
    public partial class Form1 : Form
    {
        List<Criptomoeda> criptomoeda = new List<Criptomoeda>();
        CadastroCripto cadastrar;
        ConsultarCripto consultar;
        RemoverCripto remover;
        ListarCriptos listarCriptos;
        public Form1()
        {
            InitializeComponent();
            comboBox1_ListOpcoes.SelectedIndex = 0;
        }
    
        private void button1_Menu_Ir_Click(object sender, EventArgs e)
        {
            Hide();
            if (String.IsNullOrWhiteSpace(comboBox1_ListOpcoes.Text) || !comboBox1_ListOpcoes.Items.Contains(comboBox1_ListOpcoes.Text))
           {
             MessageBox.Show("Escolha uma opção válida","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
             comboBox1_ListOpcoes.SelectedIndex = 0;
             comboBox1_ListOpcoes.Focus();
           }
           else if(comboBox1_ListOpcoes.SelectedIndex == 0)
           {
                cadastrar =  new CadastroCripto(ref criptomoeda);
                cadastrar.ShowDialog();
                cadastrar.Dispose();
           }
           else if(comboBox1_ListOpcoes.SelectedIndex == 1)
           {
                consultar = new ConsultarCripto();
                consultar.ObterCripto(ref criptomoeda);
                consultar.ShowDialog();
                consultar.Dispose();


           }
           else if(comboBox1_ListOpcoes.SelectedIndex == 2)
           {
                remover = new RemoverCripto(ref criptomoeda);
                remover.ShowDialog();
                remover.Dispose();
           }
           else
           {
                if (criptomoeda.Count > 0)
                {
                    
                    listarCriptos = new ListarCriptos(ref criptomoeda);
                    listarCriptos.ShowDialog();
                    listarCriptos.Dispose();
                }
                else
                {
                 
                    MessageBox.Show("Ainda não foram cadastrados criptos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           }
            Show();
        }

        private void comboBox1_ListOpcoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Menu_Ir.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}