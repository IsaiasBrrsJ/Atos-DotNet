using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LoginUser
{
    public  class Gravar
    {   
        public Gravar()
        {

        }
        public  bool WriteInDatabase(string login, string password)
        {   
            Conexao connection = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;


            cmd.CommandText = "insert into caduser (loginUser, passwordUser) values(@login, @password)";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                
                cmd.Connection = connection.OpenConnection();
                transaction = connection.Transaction();
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                return false;
            }
            finally
            {
                connection.CloseConnection();
                
                cmd.Dispose();
            }


         

        }
    }
}
