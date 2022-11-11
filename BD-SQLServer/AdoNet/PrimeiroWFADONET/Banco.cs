using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsADONet
{
    /*
        create login usuario with password='senha';
        create user usuario from login usuario;
        exec sp_addrolemember 'DB_DATAREADER', 'usuario';
        exec sp_addrolemember 'DB_DATAWRITER', 'usuario';
     */
    public class Banco
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=empresa_db; User ID=sa; password=sed-09lim;language=Portuguese";

        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();
                MessageBox.Show("conectado");
                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                MessageBox.Show("Não conectado");
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
                MessageBox.Show("Fechada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar banco de dados");
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}

