using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsADONet;

namespace PrimeiroWFADONET
{
     class Empregado
    {
        public int idEmpregado;
        public string nomeEmpreg;
        public int idGerente;
        public string func;
        public int idDept;
        public string dtAdmissao;
        public decimal salario;
        public decimal comissao;

        public Empregado()
        {
            this.idEmpregado = 30;
            this.nomeEmpreg = "TEste c#";
            this.idGerente = 5;
            this.func = "teste";
            this.idDept = 1;
            this.dtAdmissao = "2022-2-2";
            this.salario = 1400;
            this.comissao = 300;
        }

        public bool GravaFuncionario()
        {
            Banco b = new Banco();
            SqlConnection con = b.abrirConexao();
            SqlTransaction transact = con.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = con;
                cmd.Transaction = transact;

                cmd.CommandText = "insert into empregado values (@idEmpregado, @nomeEmpreg, @idGerente, @func, @idDept, @dtAdmissao,@salario, @comissao )";
                cmd.CommandType = CommandType.Text;
    
                cmd.Parameters.Add("@idEmpregado", SqlDbType.Int);
                cmd.Parameters.Add("@nomeEmpreg", SqlDbType.VarChar);
                cmd.Parameters.Add("@idGerente", SqlDbType.Int);
                cmd.Parameters.Add("@func", SqlDbType.VarChar);
                cmd.Parameters.Add("@idDept", SqlDbType.Int);
                cmd.Parameters.Add("@dtAdmissao", SqlDbType.VarChar);
                cmd.Parameters.Add("@salario", SqlDbType.Decimal);
                cmd.Parameters.Add("@comissao", SqlDbType.Decimal);

                cmd.Parameters[0].Value = idEmpregado;
                cmd.Parameters[1].Value = nomeEmpreg;
                cmd.Parameters[2].Value = idGerente;
                cmd.Parameters[3].Value = func;
                cmd.Parameters[4].Value = idDept;
                cmd.Parameters[5].Value = dtAdmissao;
                cmd.Parameters[6].Value = salario;
                cmd.Parameters[7].Value = comissao;

                cmd.ExecuteNonQuery();
                transact.Commit();

                return true;
            }
            catch (Exception ex)
            {
                transact.Rollback();

                return false;
            }
            finally {
                b.fecharConexao();
                    
            }



        }        
    }
}
