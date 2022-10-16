using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroExercicio.Classes
{
    class Asteroide
    {
        private double _posicao_X;
        private double _posicao_Y;
        private int _tamanhoAsteroide;
        private int _velocidadeAsteroide;
        private int _energiaAsteroide;

        #region coordenadas X and Y
        public double Posicao_X { get => _posicao_X; set => _posicao_X = value; }
        public double Posicao_Y { get => _posicao_Y; set => _posicao_Y = value; }
        #endregion
        public int TamanhoAsteroide { get => _tamanhoAsteroide; set => _tamanhoAsteroide = value; }
        public int VelocidadeAsteroide { get => _velocidadeAsteroide; set => _velocidadeAsteroide = value; }
        public int EnergiaAsteroide { get => _energiaAsteroide; set => _energiaAsteroide = value; }

        public Asteroide() { }//construtor sobrecarga vazio

        public Asteroide(double posicao_X, double posicao_Y) // coordenadas do plano cartesiano (X and Y)  
        {
            Posicao_X = posicao_X;
            Posicao_Y = posicao_Y;
        }
        public Asteroide(double posicao_X, double posicao_Y, int tamanhoAsteroide, int velocidadeAsteroide, int energiaAsteroide)
        {
            Posicao_X = posicao_X;
            Posicao_Y = posicao_Y;
            TamanhoAsteroide = tamanhoAsteroide;
            VelocidadeAsteroide = velocidadeAsteroide;
            EnergiaAsteroide = energiaAsteroide;
        }


    }
}
