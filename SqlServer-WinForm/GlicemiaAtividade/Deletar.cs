using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiaAtividade
{
    class Deletar
    {
        private Conexao cone;
        private SqlCommand cmd;
        SqlTransaction transaction;

        public Deletar()
        {
            this.cone = new Conexao();
        }

        public void deletar(int id)
        {
            string cmdDel = "DELETE FROM medidaGlicemia WHERE idMedidaGlicemia=@id";
            try
            {
                cmd = new SqlCommand(cmdDel, cone.AbrirConexao());
                transaction = cone.Transaction();
                cmd.Transaction = transaction;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Deletado com sucesso");

          
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }
    }
}
