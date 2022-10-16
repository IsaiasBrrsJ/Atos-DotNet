using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoExercicio.Classes
{
    class Operador : Funcionario
    {
        string[] cargosOperador = new[]{ "Operador de máquina", "Operador de loja", "Caixa", "Fiscal de Loja", "Segurança Estoque" };
        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Função: " +cargosOperador[new Random().Next(0, cargosOperador.Length)]);
        }
    }
}
