using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoOO.Classes
{
    class PlayStation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Estou ligando o PlayStation");
            Ligado = true;

            //ligado = true;
        }
    }
}
