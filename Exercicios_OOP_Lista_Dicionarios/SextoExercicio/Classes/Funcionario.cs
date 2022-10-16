using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoExercicio.Classes
{
    abstract class Funcionario
    {
        private string dataEntradaNoBanco;
        private string nomeFuncionario;
        private string departamento;
        private string rg;
        private double salarioFuncionario;
        private bool ativoNaEmpresa;
        
        public Funcionario() { }
        public string DataEntradaNoBanco { get => dataEntradaNoBanco; set => dataEntradaNoBanco = value; }
        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        public string RG { get => rg; set => rg = value; }
        public double SalarioFuncionario { get => salarioFuncionario; set => salarioFuncionario = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public bool AtivoNaEmpresa { get => ativoNaEmpresa; set => ativoNaEmpresa = value; }

        public abstract void ExecutaTrabalho();

        public void Demitido()
        {
            ativoNaEmpresa = false;
        }

        public void bonifica(double porcentagem)
        {
            salarioFuncionario += (salarioFuncionario * porcentagem);
        }

    }
}
