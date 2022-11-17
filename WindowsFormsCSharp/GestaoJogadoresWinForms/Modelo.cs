using System.Text;

namespace GestaoJogadoresWinForms
{
    internal class Modelo
    {

        public static void GravarLista(List<Jogador> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo);

                foreach (var jogador in lista)
                {
                    escritor.WriteLine(jogador.Nome + ";" + jogador.Email);
                }
                escritor.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exceção Capturada");
            }
        }

        public static void LerArquivo(List<Jogador> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Jogador jogador;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);

                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(";");
                    jogador = new Jogador(dadosLinha[0], dadosLinha[1]);
                    lista.Add(jogador);

                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Arquivo {nomeArquivo} não encontrado! Cadastre novos jogadores para criar o arquivo automaticamente.\n", "Atenção");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exceção Capturada11");
            }
        }       
    }
}
