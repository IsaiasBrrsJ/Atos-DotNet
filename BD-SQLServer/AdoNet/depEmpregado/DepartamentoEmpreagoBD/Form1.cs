namespace DepartamentoEmpreagoBD
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            comboBox1_menuOpc.SelectedIndex = 0;
            t = new Thread(new ThreadStart(AtualizaHora));
            t.IsBackground = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }
        private void AtualizaHora()
        {
            while (true)
            {
                label1_Hora.Invoke(new Action(() => { label1_Hora.Text = DateTime.Now.ToLongTimeString(); }));
            }
        }
    }
}