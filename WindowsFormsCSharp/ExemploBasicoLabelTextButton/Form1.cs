namespace ExemploBasicoLabelTextButton
{
    public partial class frmPrincipal : Form
    {
        List<Jogador> listaNomes = new List<Jogador>();
        string nomeArquivo = "pessoas.csv";
        public frmPrincipal()
        {
            InitializeComponent();
            Modelo.LerArquivo(listaNomes, nomeArquivo);
            AtualizarListaNome();
            lbl_totalNomes.Text = "Total: " + listaNomes.Count();
        }

        private void AtualizarListaNome()
        {
            txt_listaNomes.Clear();

            foreach (var item in listaNomes)
            {
                txt_listaNomes.AppendText(item.Nome + " - " + item.Email + Environment.NewLine);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            lbl_trocaTexto.Text = "Texto do Label Alterado";
        }

        private void btn_nomeMaiusculo_Click(object sender, EventArgs e)
        {
            if (txt_nomeJogador.Text == "")
            {
                MessageBox.Show("Digite algum texto para colocar em maiúsculo");
            }
            else
            {
                txt_nomeJogador.Text = txt_nomeJogador.Text.ToUpper();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nomeJogador.Clear();
            listaNomes.Clear();
            txt_listaNomes.Clear();
            lbl_totalNomes.Text = "Total: " + listaNomes.Count();
        }

        private void btn_inserirNome_Click(object sender, EventArgs e)
        {
            if (txt_nomeJogador.Text == "")
            {
                MessageBox.Show("Digite algum nome para inserir na lista!", "Alerta");
                txt_nomeJogador.Focus();
            }
            else
            {
                txt_nomeJogador.Text = txt_nomeJogador.Text.ToUpper();

                if (Jogador.JaCadastrado(txt_nomeJogador.Text, listaNomes))
                {
                    MessageBox.Show("Jogador já cadastrado na lista!", "Alerta");
                    txt_nomeJogador.Clear();
                    txt_nomeJogador.Focus();
                }
                else
                {
                    string[] vetorNomes = txt_nomeJogador.Text.ToLower().Split(" ");
                    string email;

                    if (vetorNomes.Length > 1)
                    {
                        email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                    }
                    else
                    {
                        email = vetorNomes[0] + "@ufn.edu.br";
                    }

                    listaNomes.Add(new Jogador(txt_nomeJogador.Text, email));
                    Jogador.OrdenarListaPorNome(listaNomes);

                    AtualizarListaNome();

                    Modelo.GravarLista(listaNomes, nomeArquivo);

                    lbl_totalNomes.Text = "Total: " + listaNomes.Count();

                    txt_nomeJogador.Clear();
                    txt_nomeJogador.Focus();
                }             
            }
        }
    }
}