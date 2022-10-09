## Locadora de Veiculos :red_car:

```
Faça um programa para controlar o aluguel de carros. Deve ter as classes Carro, aluguel e cliente.
```

### POO

__Exercicio foi desenvolvido para praticar os conceitos de orientação a objetos, como: getter e setters, classes, modifcadores de acesso e construtores.__

### __Classe Cliente__
```C#
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

```

### __Classe Carro__
```C#
    internal class Carro {
        
        private int ID;
        private string modelo;
        private string anoModelo;
        private string nomeModelo;
        private string placa;
        public Carro(string modelo, string anoModelo, string nomeModelo, string placa) {

            this.ID = GeraId();
            this.modelo = modelo;
            this.anoModelo = anoModelo;
            this.nomeModelo = nomeModelo;
            this.placa = placa;
        }

        private int GeraId() {
            return new Random().Next(0, 1000);
        }

        public int getId() {
            return ID;
        }

        public string getPlaca() {
            return placa;
        }

        public string getModelo() {
            return modelo;
        }
        public string getNomeModelo() {
            return nomeModelo;
        }

    }
```

### __Classe Aluguel__ 

```C#
    internal class Aluguel {

        public Cliente cliente;
        public Carro carro;
        private DateTime diaAluguel = DateTime.Now;
        private DateTime? devolverCarro = null;
        private bool devolucao = false;

        public bool getDevolucaoCarro() {
            return devolucao;
        }

        public void setDevolucaoCarro() {
            this.devolucao = true;
        }
        public DateTime getData() {
            return diaAluguel;
        }

        public void setDevolucao() {
            devolverCarro = DateTime.Now;
        }

        public DateTime? getDevolucao() {
            return devolverCarro;
        }
    }
```