using System;
using System.Data;
using System.Data.SqlClient;

namespace GlicemiaAtividade
{
    class Conexao
    {
        private string conexao = "Data Source=localhost; Initial Catalog=glicemia_db; User ID=sa; password=sed-09lim;language=Portuguese";
        private SqlConnection conect;
        private SqlTransaction transaction;
        public Conexao()
        {
            conect = new SqlConnection(conexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                if (conect.State.Equals(ConnectionState.Closed))
                {
                    conect.Open();
                    transaction = conect.BeginTransaction();
                    return conect;
                }

            }
            catch(SqlException ex) { }
         
            return null;

        }

        public SqlTransaction Transaction()
        {
            return transaction;
        }

        public void FecharConexao()
        {  
            if (conect.State.Equals(ConnectionState.Open))
            {
              conect.Close();

            }
        }
    }
}
