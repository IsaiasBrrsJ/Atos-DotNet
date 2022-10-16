using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoExercicio.Classes
{
    class Gerente : Funcionario
    {
        string[] cargosGerencia = new[] { "Gerente de Produção", "Gerente Horti-Fruti", "Gerente de Caixa", "Gerente de Loja", "Gerente de Estoque" };
        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Função: "+cargosGerencia[new Random().Next(0, cargosGerencia.Length)]);
        }
    }
}
