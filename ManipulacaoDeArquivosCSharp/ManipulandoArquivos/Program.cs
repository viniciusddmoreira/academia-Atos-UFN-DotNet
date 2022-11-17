namespace ManipulandoArquivos
{
    internal class Program
    {
        static void CadastrarStringArquivo()
        {
            string frase = "";
            List<string> listaDeFrases = new List<string>();

            // conecta o sistema com a base de dados
            Util.PopularArquivoNaListaString(listaDeFrases, "frases.txt");

            // lista o conteúdo da base de dados
            Console.WriteLine("Frases já cadastradas:\n");
            Util.MostrarListaString(listaDeFrases);

            while (true)
            {
                Console.Write("\nDigite uma frase para ser salva na lista de frases ou digite sair para encerrar o programa:\n");
                frase = Console.ReadLine();
                if (frase.ToUpper() == "SAIR")
                {
                    break;
                }
                // adicionar na lista a frase, desde que não esteja cadastrada
                if (listaDeFrases.Contains(frase.ToUpper()))
                {
                    Console.WriteLine("\nFrase já cadastrada na estrutura!");
                }
                else
                {
                    listaDeFrases.Add(frase);
                    // gravar ou persistir o dado no arquivo
                    Util.GravarFraseArquivo(frase, "frases.txt");
                }
            }
        }

        static void CadastrarPessoasLista()
        {
            List<Pessoa> listaDePessoas = new List<Pessoa>();

            Util.PopularArquivoNaListaPessoa(listaDePessoas, "pessoas.csv");

            string opcao;
            string nome;
            string email;
            Pessoa pessoa;
            do
            {
                Console.WriteLine("-------- MENU DE OPÇÕES --------");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listar pessoas cadastradas");
                Console.WriteLine("3 - Sair\n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nInforme o nome:");
                        nome = Console.ReadLine();

                        Console.Write("Informe o e-mail:");
                        email = Console.ReadLine();

                        Console.WriteLine(Environment.NewLine);

                        pessoa = new Pessoa(nome, email);

                        if (Util.JaNaListaPessoa(pessoa, listaDePessoas))
                        {
                            Console.WriteLine("Pessoa já cadastrada com este e-mail!\n");
                        }
                        else
                        {
                            listaDePessoas.Add(pessoa);
                            Util.GravarPessoaArquivo(pessoa, "pessoas.csv");
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nPessoas cadastradas:\n");
                        Util.MostrarListaPessoa(listaDePessoas);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente!\n");
                        break;
                }
            } while (opcao != "3");
        }

        static void Main(string[] args)
        {
            //CadastrarStringArquivo();
            CadastrarPessoasLista();
        }
    }
}