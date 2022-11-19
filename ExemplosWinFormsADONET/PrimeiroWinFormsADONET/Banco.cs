using System.Data;
using System.Data.SqlClient;

namespace PrimeiroWinFormsADONET
{
    /*
        create login usuario with password='senha';
        create user usuario from login usuario;
        exec sp_addrolemember 'DB_DATAREADER', 'usuario';
        exec sp_addrolemember 'DB_DATAWRITER', 'usuario';
     */
    public class Banco
    {
        private string stringConexao = "Data Source=DESKTOP-VTMOVEN; Initial Catalog=empresa_db; User ID=sa; password=1234;language=Portuguese";

        private SqlConnection cn;

        // vincular a string com o cn
        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {          
                conexao();
                cn.Open();
                MessageBox.Show("Banco de dados conectado com sucesso!", "Atenção");
                return cn;
            }
            catch (Exception ex)
            {              
                MessageBox.Show("Não foi possivel conectar ao banco de dados!", "Atenção");
                return null;
            }
        }

        public void fecharConexao()
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

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                // adaptar preenche o datatable com os dados do command
                adapter.Fill(dt);

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
