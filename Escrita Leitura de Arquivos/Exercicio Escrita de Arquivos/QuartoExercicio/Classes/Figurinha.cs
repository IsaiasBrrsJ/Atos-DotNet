using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio.Classes
{
    class Figurinha
    {
        /*
         codigo_figurinha, selecao, nome_jogador
         */

        private string _codFigura;
        private string _selecao;
        private string _nomeJogador;


        public Figurinha(string codFigura, string selecao, string nomeJogador)
        {
            _codFigura = codFigura;
            _selecao = selecao;
            _nomeJogador = nomeJogador;
        }

        public string getCodFigura() => _codFigura;

        public string getSelecao() => _selecao; 

        public string getNomeJogador() => _nomeJogador;
    }
}
