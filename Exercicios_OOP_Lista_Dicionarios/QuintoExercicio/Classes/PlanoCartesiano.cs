using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoExercicio.Classes
{
    class PlanoCartesiano
    {
        private double _X;
        private double _Y;
        private List<PlanoCartesiano> listPlano = new List<PlanoCartesiano>();

        public PlanoCartesiano()
        {

        }
        public double X
        {
            get => _X;
            set => _X = value;
        }
        public double Y
        {
            get => _Y;
            set => _Y = value;
        }
        public void AdcionarNaLista()
        {
            listPlano.Add(new PlanoCartesiano() { _X = X, _Y = Y });
        }

        public void ExibirLista()
        {
            foreach (var listPlanoCartesiano in listPlano)
            {
                Console.WriteLine("\nX: " + listPlanoCartesiano._X.ToString("F1") + " Y: " + listPlanoCartesiano._Y.ToString("F1"));
            }
        }

    }
}
