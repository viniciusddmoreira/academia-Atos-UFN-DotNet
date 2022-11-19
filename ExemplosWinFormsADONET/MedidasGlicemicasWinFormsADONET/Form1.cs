using System.Configuration;
using System.Data.SqlClient;

namespace MedidasGlicemicasWinFormsADONET
{
    public partial class frmPrincipal : Form
    {
        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CarregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                string sqlTexto = "SELECT medidas_glicemia.id_medida_glicemia, medidas_glicemia.valor_glicemia, " +
                "medidas_glicemia.data_medida, pacientes.nome, medidas_glicemia.id_paciente FROM medidas_glicemia, pacientes " +
                "WHERE medidas_glicemia.id_paciente = pacientes.id_paciente;";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                lv_MedidasGlicemicas.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                string[] vetorDados;
                while (leitor.Read())
                {
                    lv_MedidasGlicemicas.Items.Add(leitor["id_medida_glicemia"].ToString());
                    lv_MedidasGlicemicas.Items[i].SubItems.Add(leitor["valor_glicemia"].ToString());
                    vetorDados = leitor["data_medida"].ToString().Split(' ');
                    lv_MedidasGlicemicas.Items[i].SubItems.Add(vetorDados[0]);
                    lv_MedidasGlicemicas.Items[i].SubItems.Add(leitor["nome"].ToString());
                    lv_MedidasGlicemicas.Items[i].SubItems.Add(leitor["id_paciente"].ToString());
                    i++;
                }
                conexao.Close();
                btn_Conectar.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }

        private void LimparCampos()
        {          
            txt_ValorGlicemia.Text = "";
            txt_DataMedicao.Text = "";
            txt_IdPaciente.Text = "";
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            CarregarListView();
            btn_Cadastrar.Enabled = true;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            pnl_Campos.Enabled = true;
            txt_IdGlicemia.Text = "" + (int.Parse(lv_MedidasGlicemicas.Items[lv_MedidasGlicemicas.Items.Count - 1].SubItems[0].Text) + 1);
            txt_ValorGlicemia.Text = "";
            txt_DataMedicao.Text = "";
            txt_IdPaciente.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(txt_IdGlicemia.Text);
                int valorGlicemia = int.Parse(txt_ValorGlicemia.Text);
                string dataMedicao = txt_DataMedicao.Text;
                int idPaciente = int.Parse(txt_IdPaciente.Text);               

                string sqlUpdate = "UPDATE medidas_glicemia SET valor_glicemia = @valorGlicemia, data_medida = @dataMedida, " +
                "id_paciente = @idPaciente WHERE id_medida_glicemia = @idMedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlUpdate, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedicao);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                int contadorLinhas = comando.ExecuteNonQuery();
                MessageBox.Show("feito");

                if (contadorLinhas < 1) //se rodou o update, não faz o select
                {

                    string sqlTexto = "INSERT INTO medidas_glicemia (valor_glicemia, data_medida, id_paciente) VALUES (@valorGlicemia, @dataMedida, @idPaciente)";
                    comando = new SqlCommand(sqlTexto, conexao);
                    comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                    comando.Parameters.AddWithValue("@dataMedida", dataMedicao);
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                    //executar sentença SQL
                    comando.ExecuteNonQuery();
                }
                conexao.Close();

                //recarregar ListView
                CarregarListView();
                pnl_Campos.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conexão com o Banco " + ex.Message, "Alerta");
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(lv_MedidasGlicemicas.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM medidas_glicemia WHERE id_medida_glicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                comando.ExecuteNonQuery();
                conexao.Close();

                //recarregar ListView
                CarregarListView();

                btn_Cadastrar.Enabled = true;
                btn_Deletar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }

        private void lv_MedidasGlicemicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Deletar.Enabled = true;
            btn_Cadastrar.Enabled = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            pnl_Campos.Enabled = true;
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(lv_MedidasGlicemicas.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "SELECT id_medida_glicemia, valor_glicemia, data_medida, id_paciente FROM medidas_glicemia WHERE id_medida_glicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                SqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();
                txt_IdGlicemia.Text = leitor["id_medida_glicemia"].ToString();
                txt_ValorGlicemia.Text = leitor["valor_glicemia"].ToString();

                string[] vetorDados;
                vetorDados = leitor["data_medida"].ToString().Split();
                txt_DataMedicao.Text = vetorDados[0];
                txt_IdPaciente.Text = leitor["id_paciente"].ToString();

                conexao.Close();

                //recarregar ListView
                CarregarListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }     
    }
}