using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlicemiaAtividade
{
    public partial class CadastrarAtualizar : Form
    {
        public string? tipo = null;
        public CadastrarAtualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipo = "cadastrar";
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipo = "atualizar";
            Close();
        }

        private void CadastrarAtualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
