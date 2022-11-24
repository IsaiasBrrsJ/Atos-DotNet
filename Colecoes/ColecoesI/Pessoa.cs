using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecoesI
{
    public class Pessoa :IComparable
    {
        public Pessoa(string nome, string cPF)
        {
            Nome = nome;

            CPF = cPF;
          
        }

        public string Nome { get; set; }

        public string CPF { get; set; }
       

        //public int CompareTo(object? obj)
        //{
        //    return null;
        //}

        public override bool Equals(object? obj)
        {
            Console.WriteLine("CPF já cadastrado");
            return obj is Pessoa pessoa &&
                   CPF == pessoa.CPF;


        }
        public override string ToString()
        {
            return $"{Nome} {CPF}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(CPF);
        }

        public int CompareTo(object? obj)
        {
            Pessoa pessoa = obj as Pessoa;

            if(this.Nome == pessoa.Nome)
            {
                return 0;
            }
            else if(this.Nome.CompareTo(pessoa.Nome) < 0)
            {
                return -1;
            }

            return 1;
        }


        //public override string ToString()
        //{
        //    Console.WriteLine("Veio aqui");
        //    return $"Nome: {Nome} \nCPF: {CPF}\nDataNascimento: {dataNascimento}";
        //}


        //public int CompareTo(object? obj)
        //{
        //    Pessoa p = (Pessoa)obj;

        //    if (this.Nome == p.Nome)
        //    {
        //        return 0;
        //    }
        //    else if (Nome.CompareTo(p.Nome) < 0)
        //    {

        //        return -1;
        //    }

        //    return 1;
        //}

    }
}
