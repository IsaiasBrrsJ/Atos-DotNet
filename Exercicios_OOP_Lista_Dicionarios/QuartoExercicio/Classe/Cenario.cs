
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio.Classe
{
    class Cenario
    {
        private string descricao;
        private DateTime dataCriacao;
        private float altura;
       
        public Cenario() { }
        public string getDescricao() => descricao;
        public void setDescricao(string descricao){
            this.descricao = descricao;
        }
        public DateTime getData() => dataCriacao;
        public void setData(DateTime data)
        {
            this.dataCriacao = data;
        }

        public float getAltura() => altura;
        public void setAltura(float altura)
        {
            this.altura = altura;
        }

        public void ImprimeItensDoCenario()
        {
            Console.WriteLine("\nDescrição: "+ descricao+"\nData da Criação: "+ dataCriacao.ToString("dd/MM/yyyy")+ "\nAltura: "+ altura);
        }

        public void AhQuantoTempoOItemFoiCriado()
        {

            string resultado = "Foi Criado há: ";

            if (dataCriacao.ToShortDateString() == DateTime.Now.ToShortDateString()){
                Console.WriteLine("\nFoi criado Hoje");
                return;
            }
            else
            {
                if (dataCriacao < DateTime.Now)
                {

                    if (DateTime.Now.Year > dataCriacao.Year)
                    {
                        resultado += $"{DateTime.Now.Year - dataCriacao.Year} ano(s), ";
                    }

                    if (DateTime.Now.Month > dataCriacao.Month)
                    {
                        resultado += $"{DateTime.Now.Month - dataCriacao.Month} mes(es), ";
                    }

                    if (dataCriacao.Day.ToString().TrimStart('-') != "0")
                    {
                        resultado += $"{(DateTime.Now.Day - dataCriacao.Day).ToString().Trim('-')} Dia(s)"; /// caso seja negativo o trim remove o -
                    }
                }
                else
                    resultado = "\nAinda não foi criado, está apenas agendado para: "+ dataCriacao.ToShortDateString();

            }


            Console.WriteLine(resultado);
        }
    }
}
