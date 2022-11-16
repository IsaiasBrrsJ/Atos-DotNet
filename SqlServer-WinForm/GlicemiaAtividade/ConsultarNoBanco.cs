using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiaAtividade
{
    class ConsultarNoBanco
    {
        private Conexao connect;
        private SqlCommand command;
        private string select = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida, [Paciente].nome, [Paciente].idPaciente, [Paciente].email FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
        public ConsultarNoBanco()
        {
            connect = new Conexao();
        }

        public void adcionaLisView(ref ListView listview)
        {
            listview.Items.Clear();
            try
            {
                
                command = new SqlCommand(select, connect.AbrirConexao(), connect.Transaction());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listview.Items.Add(
                       new ListViewItem(new[]{ 
                       reader["idMedidaGlicemia"].ToString(),
                       reader["valorGlicemia"].ToString(),
                       reader["dataMedida"].ToString().Split(' ')[0],
                       reader["nome"].ToString(),
                       reader["idPaciente"].ToString(),
                       reader["email"].ToString() })
                    );
                }
             
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   
                connect.FecharConexao();
            }

        }
    }
}
