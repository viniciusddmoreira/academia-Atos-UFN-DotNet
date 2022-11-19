using System.Data;
using System.Data.SqlClient;

namespace SQLInjectionWinForms
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public float peso;

        public bool Gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transacao;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO pessoas VALUES (@nome, @peso);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@peso", SqlDbType.Float);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = peso;

            try
            {
                cmd.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                transacao.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public DataTable FiltrarNome()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();           

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;
          
            cmd.CommandText = "SELECT * FROM pessoas WHERE nome=@filtroNome";
            cmd.Parameters.Add("@filtroNome", SqlDbType.VarChar);
            cmd.Parameters[0].Value = nome;

            try
            {

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
