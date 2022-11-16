using JetBrains.Annotations;
using System.Data;

namespace GlicemiaAtividade
{
    public partial class Form1 : Form
    {
       
        ConsultarNoBanco cosultar;
        string tipo = null;
        public Form1()
        {
            InitializeComponent();
            cosultar = new ConsultarNoBanco();
            
        
        }

        private void button1_Conectar_Click(object sender, EventArgs e)
        {
            
           cosultar.adcionaLisView(ref listView1);

           button2_Cadastrar.Enabled = true;
           
           button4_Editar.Enabled = true;
        }


        private void button2_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAtualizar cd = new CadastrarAtualizar();
            cd.ShowDialog();
             tipo = cd.tipo;
            
            if(tipo != null)
            {
                panel1.Enabled = true;
            }

            if(tipo == "cadastrar")
            {
                textBox3_IdPaciente.Enabled = true;
                textBox4_Paciente.Enabled = true;
                textBox5_Email.Enabled = true;

            }
            else if(tipo != null)
            {
                textBox3_IdPaciente.Enabled = false;
                textBox4_Paciente.Enabled = false;
                textBox5_Email.Enabled = false;
            }
            cd.Dispose();
           
        }
        public void Atualizar()
        {
            var idGli = Convert.ToInt32(textBox1_IdGlicemia.Text);
            var valorGli = Convert.ToInt32(textBox2_ValorGlicemico.Text);
            var dateGl = Convert.ToDateTime(dateTimePicker1_DataMedicao.Text);

            Atualizar at = new Atualizar();
            at.Update(valorGli, dateGl, idGli);
        }
        public void Cadastrar()
        {
            var idGlicemia = Convert.ToInt32(textBox1_IdGlicemia.Text);
            var valorGlicemia = Convert.ToInt32(textBox2_ValorGlicemico.Text);
            var dataMedida = Convert.ToDateTime(dateTimePicker1_DataMedicao.Text);
            var idPaciente = Convert.ToInt32(textBox3_IdPaciente.Text);
            var nome = textBox4_Paciente.Text;
            var email = textBox5_Email.Text;

            Cadastrar cad = new Cadastrar();
            cad.InserirNoBanco(idGlicemia, valorGlicemia, dataMedida, idPaciente, nome, email);

          

        }

        private void button1_Limpar_Click(object sender, EventArgs e)
        {
            textBox1_IdGlicemia.Text = String.Empty;
            textBox2_ValorGlicemico.Text = String.Empty;
            textBox3_IdPaciente.Text = String.Empty;
            textBox4_Paciente.Text = String.Empty;
            textBox5_Email.Text = String.Empty;
            dateTimePicker1_DataMedicao.Text = String.Empty;
            textBox4_Paciente.Enabled = false;
            textBox5_Email.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Deletar_Click(object sender, EventArgs e)
        {   
            
            var id = 0;
           
           var a = MessageBox.Show("Certeza que deseja remover ", "Aviso",MessageBoxButtons.YesNo);
            if(a is DialogResult.Yes)
            {


                id = Convert.ToInt32(listView1.SelectedItems[0].Text);
               
                listView1.SelectedItems[0].Remove();
             
            }
            else
            {
                MessageBox.Show("Não foi removido");
            }

            Deletar del = new Deletar();
            del.deletar(id);
            

            button3_Deletar.Enabled = false;
            textBox3_IdPaciente.Enabled = true;
        }

  

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                button3_Deletar.Enabled = true;
            }
            else
            {
                button3_Deletar.Enabled = false;
            }
        }

        private void button4_Editar_Click(object sender, EventArgs e)
        {
            button3_Deletar.Enabled = false;
        }

        private void button2_Gravar_Click(object sender, EventArgs e)
        {   
            if(tipo == "cadastrar")
            {
                Cadastrar();
            }
            else
            {
                Atualizar();
            }
         
            panel1.Enabled = false;
            tipo = null;

            cosultar.adcionaLisView(ref listView1);
        }
    }
}