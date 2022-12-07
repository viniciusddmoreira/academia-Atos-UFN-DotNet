using System.Data;

namespace CadastroPessoasWinFormsADONET
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txt_Nome.Text;
            p.peso = float.Parse(txt_Peso.Text);

            if (p.Gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesso!", "Alerta");
            }
            else
            {
                MessageBox.Show("Erro ao inserir a pessoa!", "Atenção");

            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.ExecutarConsulta("SELECT * FROM pessoas;");

            dgv_Consultas.DataSource = dt;

        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            // SQL Injection
            //Banco bd = new Banco();
            //DataTable dt = new DataTable();
            //dt = bd.ExecutarConsulta("SELECT * FROM pessoas WHERE nome= '" + txt_Consultar.Text + "'");

            Pessoa p = new Pessoa();
            p.nome = txt_Consultar.Text;
            dgv_Consultas.DataSource = p.FiltrarNome();

        }
    }
}