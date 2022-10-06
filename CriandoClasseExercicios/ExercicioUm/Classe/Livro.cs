using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm {
    internal class Livro {


        private string Titulo;
        private string Autor;
        private string Editora;
        private string AnoLancamento;
        private string TipoDeCapa;
        private decimal Valor;
        private int Paginas;

        public Livro(
            string titulo, string autor, string editora, string
            anoLancamento, string tipoCapa, decimal valor, int paginas)
            {

            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.AnoLancamento = anoLancamento;
            this.TipoDeCapa = tipoCapa;
            this.Valor = valor;
            this.Paginas = Paginas;
        }

    }
}
