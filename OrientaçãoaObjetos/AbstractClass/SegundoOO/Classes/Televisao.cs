using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoOO.Classes
{
    class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("WebOs iniciando");
            //ligado = true;
            Ligado = true;
        }
    }
}
