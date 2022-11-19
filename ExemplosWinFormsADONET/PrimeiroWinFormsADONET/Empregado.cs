using System.Data.SqlClient;
using System.Data;

namespace PrimeiroWinFormsADONET
{
    internal class Empregado
    {
        public int IdEmpregado { get; set; }
        public string Nome { get; set; }
        public int IdGerente { get; set; }
        public string Funcao { get; set; }
        public int IdDepartamento { get; set; }
        public string DataAdmissao { get; set; }
        public int Salario { get; set; }
        public int Comissao { get; set; }

        public Empregado(int idEmpregado, string nome, int idGerente, string funcao, int idDepartamento, string dataAdmissao, int salario, int comissao)
        {
            IdEmpregado = idEmpregado;
            Nome = nome;
            IdGerente = idGerente;
            Funcao = funcao;
            IdDepartamento = idDepartamento;
            DataAdmissao = dataAdmissao;
            Salario = salario;
            Comissao = comissao;
        }

        public bool gravarEmpregado()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO empregados VALUES (@idEmpregado, @nome, @idGerente, @funcao, @idDepartamento, @dataAdmissao, @salario, @comissao);";
            cmd.Parameters.Add("@idEmpregado", SqlDbType.Int);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idGerente", SqlDbType.Int);
            cmd.Parameters.Add("@funcao", SqlDbType.VarChar); //SqlDbType.Int
            cmd.Parameters.Add("@idDepartamento", SqlDbType.Int);
            cmd.Parameters.Add("@dataAdmissao", SqlDbType.Date);
            cmd.Parameters.Add("@salario", SqlDbType.Int);
            cmd.Parameters.Add("@comissao", SqlDbType.Int);
            cmd.Parameters[0].Value = IdEmpregado;
            cmd.Parameters[1].Value = Nome;
            cmd.Parameters[2].Value = IdGerente;
            cmd.Parameters[3].Value = Funcao;
            cmd.Parameters[4].Value = IdDepartamento;
            cmd.Parameters[5].Value = DataAdmissao;
            cmd.Parameters[6].Value = Salario;
            cmd.Parameters[7].Value = Comissao;

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
