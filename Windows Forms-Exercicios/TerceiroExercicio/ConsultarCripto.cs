using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerceiroExercicio.classes;

namespace TerceiroExercicio
{

    public partial class ConsultarCripto : Form
    {
        private List<Criptomoeda> cripot = new List<Criptomoeda>();
        public ConsultarCripto()
        {
            InitializeComponent();
        }
        public void ObterCripto(ref List<Criptomoeda> criptomoedas)
        {
            cripot = criptomoedas;
        }
        private void textBox1_SiglaConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Consultar.PerformClick();
            }
        }

        private void button1_Consultar_Click(object sender, EventArgs e)
        {
           
            bool encontrouCripto = false;
            foreach (var criptos in cripot)
            {
                if (criptos.getSiglaCripto().Equals(textBox1_SiglaConsultar.Text))
                {
                    textBox1_ExibeCripto.Text = "Nome: "+ criptos.getNomeCripto() + Environment.NewLine +"Sigla: "+ criptos.getSiglaCripto().ToString() +
                    Environment.NewLine +"Valor: "+ criptos.getValorCripto().ToString("C");
                    encontrouCripto = true;
                    break;
                }
            }
            if (encontrouCripto is false)
            {
                MessageBox.Show("CriptoMoeda Não Encotrada");
            }
        }


    }
}
