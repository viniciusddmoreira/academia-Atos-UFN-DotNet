using System.Data.SqlClient;
using System.Data;

namespace PrimeiroWinFormsADONET
{
    internal class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Orcamento { get; set; }

        public Departamento(int idDepartamento, string nome, string localizacao, string orcamento)
        {
            IdDepartamento = idDepartamento;
            Nome = nome;
            Localizacao = localizacao;
            Orcamento = orcamento;
        }

        public bool gravarDepartamento()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO departamentos VALUES (@idDepartamento, @nome, @localizacao, @orcamento);";
            cmd.Parameters.Add("@idDepartamento", SqlDbType.Int);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@localizacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@orcamento", SqlDbType.VarChar); //SqlDbType.Int
            cmd.Parameters[0].Value = IdDepartamento;
            cmd.Parameters[1].Value = Nome;
            cmd.Parameters[2].Value = Localizacao;
            cmd.Parameters[3].Value = Orcamento;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }
    }
}
