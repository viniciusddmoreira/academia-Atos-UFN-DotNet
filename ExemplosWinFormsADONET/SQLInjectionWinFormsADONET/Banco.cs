using System.Data;
using System.Data.SqlClient;

namespace SQLInjectionWinFormsADONET
{

/*
create database crud_db;

use crud_db;

create login usuario with password='senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';


create table programadores  (
id INT NOT NULL IDENTITY,
  nome VARCHAR(45) NOT NULL,
  linguagem VARCHAR(45) NOT NULL,
  banco VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (id)
);

 */
    public class Banco
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=crud_db; User ID=usuario; password=senha;language=Portuguese";

        private SqlConnection cn;

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

                return cn;
            }
            catch (Exception ex)
            {
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
