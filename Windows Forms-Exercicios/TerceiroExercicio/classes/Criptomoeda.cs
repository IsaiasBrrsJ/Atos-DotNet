using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroExercicio.classes
{
    public class Criptomoeda
    {
        private string _nomeCripto;
        private string _siglaCripto;
        private double _valorCripto;

        public Criptomoeda(string nomeCripto, string siglaCripto, double valorCripto)
        {
            _nomeCripto = nomeCripto;
            _siglaCripto = siglaCripto;
            _valorCripto = valorCripto;
        }

        public string getNomeCripto() => _nomeCripto;
        public string getSiglaCripto() => _siglaCripto;
        public double getValorCripto() => _valorCripto;
    }
}
