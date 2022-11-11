using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Common;

namespace LoginUser
{
     class Conexao
    {
        private string conexao = "Data Source=localhost; Initial Catalog=usuario; User ID=sa; password=xxxx;language=Portuguese";
        SqlTransaction transaction;
        SqlConnection conect;
        // SqlConnection, passo o caminho do meu banco de dados, servidor ex, onde vou acessar.  

        public Conexao()
        {   
            
            conect = new SqlConnection(conexao);
            // ao instanciar a classe conexão instancio tbm minha conexao com banco;
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (conect.State.Equals(ConnectionState.Closed))
                {
                    conect.Open();
                    transaction = conect.BeginTransaction();
                    MessageBox.Show("Abriu conexao");
                    // Verifica se a conexão está fechada, caso esteja, então, se abre a conexão;
                }
                return conect;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
  
        }

        public SqlTransaction Transaction()
        {
            return transaction;
        }

        public void CloseConnection()
        {
            try
            {
                if (conect.State.Equals(ConnectionState.Open))
                {
                    conect.Close();
                }
            }
            catch(SqlException ex)
            {
                return;
            }
        }


    }
}
