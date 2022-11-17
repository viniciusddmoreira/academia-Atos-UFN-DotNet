namespace ExemploBasicoWinForms
{
    public partial class frmPrincipal : Form
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "ATENÇÃO");
            }
            else if (txtNomeCompleto.Text.Length > 1)
            {
                if (Pessoa.JaCadastrado(txtNomeCompleto.Text, listaPessoas))
                {
                    MessageBox.Show("Nome já cadastrado!", "ATENÇÃO");
                }
                else
                {
                    Pessoa pessoa = new Pessoa(txtNomeCompleto.Text, txtEmail.Text);
                    listaPessoas.Add(pessoa);
                    OrdenarListaPorNome();
                    atualizarTextBox_listaNomes();
                    limparCampos();
                }
            }
        }
        private void OrdenarListaPorNome()
        {
            listaPessoas.Sort(delegate (Pessoa pessoaA, Pessoa pessoaB)
            {
                return pessoaA.Nome.CompareTo(pessoaB.Nome);
            });         
        }      

        private void limparCampos()
        {
            txtNomeCompleto.Clear();
            txtEmail.Clear();
        }    

        private void atualizarTextBox_listaNomes()
        {
            txtListaNomes.Text = String.Empty;
            foreach (var item in listaPessoas)
            {
                txtListaNomes.Text += item.Nome + Environment.NewLine;
            }
        }

        private void btnListarDominios_Click(object sender, EventArgs e)
        {
            string[] dados;
            txtListaDominios.Text = String.Empty;

            foreach (var item in listaPessoas)
            {
                dados = item.Email.Split("@");
                txtListaDominios.Text += dados[1] + Environment.NewLine;
            }
        }

        private void btnListarEmails_Click(object sender, EventArgs e)
        {
            string[] dados;
            txtListaEmails.Text = String.Empty;

            foreach (var item in listaPessoas)
            {
                dados = item.Email.Split("@");
                txtListaEmails.Text += dados[0] + Environment.NewLine;
            }
        }
    }
}