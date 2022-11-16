using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiaAtividade
{
    class Atualizar
    {
        private Conexao con;
        private SqlCommand command;
        private SqlTransaction transaction;

        public Atualizar()
        {
            con = new Conexao();
        }

        public void Update(int valorGli, DateTime date, int id)
        {
            string update = "UPDATE MedidaGlicemia set valorGlicemia=@valorGli, dataMedida=@date WHERE idMedidaGlicemia = @id";
            try
            {
               
                command = new SqlCommand(update, con.AbrirConexao(), con.Transaction());
                transaction = command.Transaction;
                command.Parameters.Add("@valorGli", System.Data.SqlDbType.Int).Value = valorGli;
                command.Parameters.Add("@date", System.Data.SqlDbType.Date).Value= date;
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
                transaction.Commit();


            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}
