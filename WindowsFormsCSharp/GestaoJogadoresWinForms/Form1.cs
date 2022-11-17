namespace GestaoJogadoresWinForms
{
    public partial class frmPrincipal : Form
    {
        List<Jogador> listaJogadores = new List<Jogador>();
        string nomeArquivo = "pessoas.csv";
        public frmPrincipal()
        {
            InitializeComponent();
            Modelo.LerArquivo(listaJogadores, nomeArquivo);
            AtualizarListaJogadores();
            lbl_totalNomes.Text = "Total: " + listaJogadores.Count();
        }

        private void AtualizarListaJogadores()
        {
            txt_listaNomes.Clear();

            foreach (var item in listaJogadores)
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
            listaJogadores.Clear();
            txt_listaNomes.Clear();
            lbl_totalNomes.Text = "Total: " + listaJogadores.Count();       
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

                if (Jogador.JaCadastrado(txt_nomeJogador.Text, listaJogadores))
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

                    listaJogadores.Add(new Jogador(txt_nomeJogador.Text, email));
                    Jogador.OrdenarListaPorNome(listaJogadores);

                    AtualizarListaJogadores();

                    Modelo.GravarLista(listaJogadores, nomeArquivo);

                    lbl_totalNomes.Text = "Total: " + listaJogadores.Count();

                    txt_nomeJogador.Clear();
                    txt_nomeJogador.Focus();
                }             
            }
        }
    }
}