using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoOO
{
    interface IEletronico
    {
        //interface não pode conter atributos;
        //private int _volts;
        //private int _potencia;
        //private bool _ligado;

        public void Ligar();
        public void Desligar();

    }
}
