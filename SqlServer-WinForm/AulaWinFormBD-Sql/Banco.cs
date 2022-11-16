using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AulaWinFormBD_Sql
{
     class Banco
    {
        private string conec = "Data Source=localhost; Initial Catalog=aula; User ID=usuarioAtos; password=admin123; language=Portuguese";


        private SqlConnection cn;

        private void conexao()
        {
             cn = new SqlConnection(conec); 
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;

            }catch(SqlException ex)
            {
                return null;
            }
        }
        public void FecharConexao()
        {
            try
            {
                cn.Close();

            }catch(SqlException ex)
            {
                return; 
            }
        }

        public DataTable ExecutaConsulta(string sql, int? consultarTudo = null)
        {
         

            try
            {   
                abrirConexao();
                string comando = "";
                if (consultarTudo != null)
                {
                    comando = "SELECT * FROM pessoas";
                }
                else
                {
                    comando = "SELECT * FROM pessoas WHERE nome=@sql";
                }

                SqlCommand sqlCommnad = new SqlCommand();
                sqlCommnad.CommandType = CommandType.Text;
                sqlCommnad.Connection = cn;
               
                sqlCommnad.CommandText = comando;
                sqlCommnad.Parameters.Add("@sql", System.Data.SqlDbType.VarChar).Value = sql;
                sqlCommnad.ExecuteNonQuery();
                

                SqlDataAdapter adpter = new SqlDataAdapter(sqlCommnad);
                DataTable dt = new DataTable();
                adpter.Fill(dt);

                return dt;
            }
         
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }

          
        }
    }
}
