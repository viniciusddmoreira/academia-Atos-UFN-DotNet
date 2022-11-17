using System.Text;

namespace ManipulandoArquivos
{
    internal class Util
    {
        // método de classe
        public static void GravarFraseArquivo(string frase, string nomeArquivo)
        {
            // abre o arquivo para escrita
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);
            escritor.WriteLine(frase.ToUpper());
            escritor.Flush();
            escritor.Close();
        }

        public static void GravarPessoaArquivo(Pessoa pessoa, string nomeArquivo)
        {
            // abre o arquivo para escrita
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);
            escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email);
            escritor.Flush();
            escritor.Close();
        }

        public static void PopularArquivoNaListaString(List<string> lista, string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    lista.Add(leitor.ReadLine());
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Arquivo {nomeArquivo} não encontrado! Cadastre novas frases para criar o arquivo automaticamente.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção: " + ex.Message);
            }
        }

        public static void PopularArquivoNaListaPessoa(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Pessoa pessoa;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(";");
                    pessoa = new Pessoa(dadosLinha[0], dadosLinha[1]);
                    lista.Add(pessoa);
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Arquivo {nomeArquivo} não encontrado! Cadastre novas pessoas para criar o arquivo automaticamente.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção: " + ex.Message);
            }
        }

        public static void MostrarListaString(List<string> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine(i);
            }
        }

        public static void MostrarListaPessoa(List<Pessoa> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine("Nome: " + i.Nome + " - Email: " + i.Email);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static bool JaNaListaPessoa(Pessoa pessoa, List<Pessoa> lista)
        {
            foreach (var i in lista)
            {
                if (pessoa.Email == i.Email)
                {
                    // pessoa localizada pelo email
                    return true;
                }
            }
            // pessoa não localizada pelo email
            return false;
        }
    }
}
