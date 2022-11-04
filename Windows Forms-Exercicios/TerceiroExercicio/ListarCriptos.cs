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
    public partial class ListarCriptos : Form
    {
        public ListarCriptos(ref List<Criptomoeda> cript)
        {
            InitializeComponent();

            if(cript.Count == 0) { 
            
            
                foreach (var cripto in cript)
                {
                    textBox1_ListCriptomoedas.Text += "Nome: "+cripto.getNomeCripto() + Environment.NewLine +"Sigla: "+ cripto.getSiglaCripto() + Environment.NewLine +"Valor: "+cripto.getValorCripto().ToString("C") +
                        Environment.NewLine + "---------------------"+Environment.NewLine;
                }
            }


        }

        private void ListarCriptos_Load(object sender, EventArgs e)
        {

        }
    }
}
