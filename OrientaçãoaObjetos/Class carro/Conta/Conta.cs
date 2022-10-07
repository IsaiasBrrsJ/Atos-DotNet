using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta {
    internal class Conta {

        public Cliente cliente;
        private decimal saldo;
        public string tipo = "corrente";

        public Conta(Cliente cliente, decimal saldo, string tipo) {
            this.cliente = cliente;
            this.saldo = saldo;
            this.tipo = tipo;
        }

        public void creditar(decimal valor) {
            saldo += valor;
            Console.WriteLine("Creditado "+ valor);
        }

        public void debitar(decimal valor) {
            saldo -= valor;
            Console.WriteLine("Debitado " + valor);
        }

        public decimal getSaldo() {
            return saldo;
        }
    }
}
