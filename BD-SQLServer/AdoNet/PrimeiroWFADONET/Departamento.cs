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
    class Departamento
    {
        public int id;
        public string nome;
        public string localizacao;
        public decimal orcamento;

        public Departamento()
        {

        }

        public bool GravarDepartamento()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transasction = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            try
            {
                
                 cmd.Connection = cn;
                 cmd.Transaction = transasction;

                 cmd.CommandType = CommandType.Text;

                 cmd.CommandText = "insert into departamento values (@id, @nome, @localizacao, @orcamento)";
                 cmd.Parameters.Add("@id", SqlDbType.Int);
                 cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                 cmd.Parameters.Add("@localizacao", SqlDbType.VarChar);
                 cmd.Parameters.Add("@orcamento", SqlDbType.Decimal);
                 cmd.Parameters[0].Value = id;
                 cmd.Parameters[1].Value = nome;
                 cmd.Parameters[2].Value = localizacao;
                 cmd.Parameters[3].Value = orcamento;

           
                cmd.ExecuteNonQuery();
                transasction.Commit();
                return true;
            }
            catch
            {
               
                transasction.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
              
            }

         
        }

    }
}
