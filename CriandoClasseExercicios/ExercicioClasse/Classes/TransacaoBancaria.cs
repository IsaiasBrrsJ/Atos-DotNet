using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasse {
    internal class TransacaoBancaria {

        public string Agencia;
        public string TipoDeConta;
        public decimal Valor;
        public string Conta;

        public TransacaoBancaria() {
            Conta = "123456-3";
            Agencia = "010-1";
            TipoDeConta = "Corrente";
            Valor = 335.65m;

        }
        public void Sacar() {
            Valor -= 180;
            Console.WriteLine("Saque realizado com sucesso, seu saldo é de "+ Valor);
        }
        public void Depositar() {
            Valor += 30;
            Console.WriteLine("Deposito efetuado. O saldo é"+ Valor);
        }

        public void ConsultarSaldo() {
            Console.WriteLine("O saldo da conta é: " +Valor);
        }
        public void ExibirDados() {
            Console.WriteLine("Exibindo dados: Agencia: {0} Conta: {1} Tipo de Conta: {2}", Agencia, Conta, TipoDeConta);
        }

    }
}
