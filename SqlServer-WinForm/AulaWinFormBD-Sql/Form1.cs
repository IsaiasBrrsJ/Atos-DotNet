using System.Data;

namespace AulaWinFormBD_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.peso = float.Parse(txtPeso.Text);

            if (p.gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesso!");
            }else
            {
                MessageBox.Show("Erro ao inserir a Pessoa!");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutaConsulta(txtFiltro.Text, 1);
            dataGridView1.DataSource = dt;
            
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutaConsulta(txtFiltro.Text);
            dataGridView1.DataSource = dt;
        }
    }
}