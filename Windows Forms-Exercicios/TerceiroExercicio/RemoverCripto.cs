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
    public partial class RemoverCripto : Form
    {
        List<Criptomoeda> cripto;
        public RemoverCripto(ref List<Criptomoeda> cripto)
        {
            this.cripto = cripto;
            InitializeComponent();
        }

        private void RemoverCripto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_SiglaRemover_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == (char)Keys.Enter)
            {
                button1_RemoverCripto.PerformClick();
            }
        }

        private void button1_RemoverCripto_Click(object sender, EventArgs e)
        {
            if (existeNaLista())
            {
                foreach (var criptomoedas in cripto)
                {
                    if (criptomoedas.getSiglaCripto() == textBox1_SiglaRemover.Text)
                    {
                        var dialog = MessageBox.Show($"Deseja Realmente Remover [{criptomoedas.getNomeCripto()}]", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == dialog)
                        {
                            cripto.Remove(criptomoedas);
                            MessageBox.Show("Removido Com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("Remoção Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cripto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool existeNaLista()
        {
            foreach (var cript in cripto)
            {
                if(cript.getSiglaCripto() == textBox1_SiglaRemover.Text)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
