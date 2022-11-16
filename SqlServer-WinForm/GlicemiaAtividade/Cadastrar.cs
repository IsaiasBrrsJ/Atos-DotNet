using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiaAtividade
{
     class Cadastrar
    {
        private Conexao conec;
        private SqlCommand coma;
        private SqlTransaction transaction;

        public Cadastrar()
        {
            conec = new Conexao();
        }

        public void InserirNoBanco(int idMedidaGlicemia, int valorGlicemia, DateTime dataMedida, int idPaciente,
            string nome, string email)
        {
            string sqlPaciente = "INSERT INTO Paciente(IdPaciente, nome, email) values(@idPaciente, @nome, @email)";

            string sqlGlicemia = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";

            try
            {

                coma = new SqlCommand(sqlPaciente, conec.AbrirConexao());
             

                coma.Parameters.Add("@idPaciente", System.Data.SqlDbType.Int).Value = idPaciente;
                coma.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome;
                coma.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = email;
                transaction = conec.Transaction();
                coma.Transaction = transaction;
                coma.ExecuteNonQuery();
                
                transaction.Commit();
                conec.FecharConexao();

                coma = new SqlCommand(sqlGlicemia, conec.AbrirConexao());
                coma.Parameters.Add("@idMedidaGlicemia", System.Data.SqlDbType.Int).Value = idMedidaGlicemia;
                coma.Parameters.Add("@valorGlicemia", System.Data.SqlDbType.Int).Value = valorGlicemia;
                coma.Parameters.Add("@dataMedida", System.Data.SqlDbType.Date).Value = dataMedida;
                coma.Parameters.Add("@idPaciente", System.Data.SqlDbType.Int).Value = idPaciente;
                transaction = conec.Transaction();
                coma.Transaction = transaction;
                coma.ExecuteNonQuery();

                transaction.Commit();
                          

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conec.FecharConexao();
            }

        }

       
    }
}
