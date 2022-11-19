using System.Data;
using System.Data.SqlClient;

namespace SQLInjectionWinForms
{
    internal class Banco
    {
        private string conec = "Data Source=localhost;Initial Catalog=aula_db; User ID=usuarioAtos; password=admin123; language=Portuguese";

        private SqlConnection cn;

        private void Conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                AbrirConexao();
                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch(Exception e)
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
