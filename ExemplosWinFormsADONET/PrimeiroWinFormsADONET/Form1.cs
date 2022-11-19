namespace PrimeiroWinFormsADONET
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(int.Parse(txt_IdDPTO.Text), txt_NomeDPTO.Text, txt_LocalizacaoDPTO.Text, txt_OrcamentoDPTO.Text);

            if (d.gravarDepartamento())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Departamento!", "Erro");
        }

        private void btn_SalvarEMP_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado(int.Parse(txt_IdEMP.Text), txt_NomeEMP.Text, int.Parse(txt_idGerenteEMP.Text), txt_FuncaoEMP.Text, int.Parse(txt_idDepartamentoEMP.Text), txt_DataAdmissaoEMP.Text, int.Parse(txt_SalarioEMP.Text), int.Parse(txt_ComissaoEMP.Text));

            if (emp.gravarEmpregado())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Empregado!", "Erro");
        }
    }
}