using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_veiculos.Classes {
    internal class Cliente {

        private int ID;
        private string nome;
        private string endereco;
        private string cpf;
        private string telefone;


        public Cliente(string nome, string endereco, string cpf, string telefone) {
            ID = GeraId();
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        private int GeraId() {

            return new Random().Next(0, 1000);
        }

        public string getCPF() {
            return cpf;
        }
        public string getNome() {
            return nome;
        }
        public string getEndereco() {
            return endereco;
        }
        public string getTelefone() {
            return telefone;
        }
    }
}
