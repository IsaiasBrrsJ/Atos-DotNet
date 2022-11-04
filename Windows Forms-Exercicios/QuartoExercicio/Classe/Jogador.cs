using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio.Classe
{
    class Jogador
    {
        private string _nomeJogador;
        private string _emailJogador;

        public Jogador(string nomeJogador, string emailJogador)
        {
            _nomeJogador = nomeJogador;
            _emailJogador = emailJogador;
        }

        public string getNomeJogador() => _nomeJogador;
        public string getEmailJogador() => _emailJogador;

    }
}
