namespace LeituraEscritaArquivos
{
    internal class Program
    {
        static bool ValidarCampos(string campo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                Console.WriteLine("Este campo é obrigatório, tente novamente.");
                return true;
            } else
                return false;             
        }

        static void EscritaArquivo()
        {
            //Escrita de arquivo          
            //StreamWriter escritor = new StreamWriter("C:\\Users\\Vinicius\\Documents\\AcademiaAtos\\academia-Atos-UFN-dotnet\\LeituraEscritaArquivos\\LeituraEscritaArquivos\\bin\\Debug\\net6.0\\AtosUfn.txt");
            //StreamWriter escritor = new StreamWriter(@"C:\Users\Vinicius\Documents\AcademiaAtos\academia-Atos-UFN-dotnet\LeituraEscritaArquivos\LeituraEscritaArquivos\bin\Debug\net6.0\AtosUfn.txt");
            StreamWriter escritor = new StreamWriter("AtosUfn.txt");

            escritor.WriteLine("Hoje é segunda-feira!");
            escritor.WriteLine("Aula Atos-UFN");
            escritor.WriteLine();
            escritor.WriteLine();
            escritor.WriteLine("17-10-2022");
            escritor.Close();
        }

        static void LeituraArquivo()
        {
            //Leitura de arquivo
            //StreamReader leitor = new StreamReader("C:\\Users\\Vinicius\\Documents\\AcademiaAtos\\academia-Atos-UFN-dotnet\\LeituraEscritaArquivos\\LeituraEscritaArquivos\\bin\\Debug\\net6.0\\AtosUfn.txt");
            //StreamReader leitor = new StreamReader(@"C:\Users\Vinicius\Documents\AcademiaAtos\academia-Atos-UFN-dotnet\LeituraEscritaArquivos\LeituraEscritaArquivos\bin\Debug\net6.0\AtosUfn.txt");
            StreamReader leitor = new StreamReader("AtosUfn.txt");           

            Console.WriteLine("---------------------------------------------");

            string? linha;
            while ((linha = leitor.ReadLine()) != null)
                Console.WriteLine(linha);

            Console.WriteLine("---------------------------------------------");

            leitor.Close();
        }

        static void ExemploEscritaArquivo()
        {
            //Gerar um arquivo, utilizando o ; como caractere delimitador para cada uma dessas informações abaixo      
            //Nome, idade, sexo, email, telefone, estado civil, casa propria, valor aluguel            
            //Todas as informações, ficam na mesma linha - cada linha é uma pessoa            
            //Apenas nome, idade e casa propria são campos obrigatórios

            //Exemplo do arquivo txt salvo:           
            //Fabrício;21;;;;;Sim;0

            string nome;
            do
            {
                Console.WriteLine("Informe o nome:");
                nome = Console.ReadLine();
            } while (ValidarCampos(nome));

            int idade = 0;
            bool idadeValidada;
            do
            {
                try
                {
                    Console.WriteLine("Informe a idade:");
                    idade = int.Parse(Console.ReadLine());
                    idadeValidada = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato inválido, tente novamente.");
                    idadeValidada = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                    idadeValidada = true;                   
                }
            } while (idadeValidada);
                  
            Console.WriteLine("Informe o sexo:");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe o e-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Informe o telefone:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Informe o estado civil:");
            string estadoCivil = Console.ReadLine();

            int casaPropria = 0;
            bool CasaPropriaValidada;
            do
            {
                try
                {
                    Console.WriteLine("Informe se possui casa propria: (1 - Sim / 2 - Não)");
                    casaPropria = int.Parse(Console.ReadLine());
                    CasaPropriaValidada = false;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Formato inválido, tente novamente.");
                    CasaPropriaValidada = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                    CasaPropriaValidada = true;
                }              
            } while (CasaPropriaValidada);
            
            double valorAluguel = 0;
            if (casaPropria == 2)
            {
                Console.WriteLine("Informe o valor do aluguel:");
                valorAluguel = double.Parse(Console.ReadLine());
            }

            try
            {
                StreamWriter escritor = new StreamWriter("ExemploEscritaArquivo.txt");

                escritor.WriteLine(nome + ";" + idade + ";" + sexo + ";" + email + ";" + telefone + ";" + estadoCivil + ";" + (casaPropria == 1 ? "Sim" : "Não") + ";" + valorAluguel);
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
        }

        static void ExemploEscritaLeituraArquivo()
        {
            //Gerar um arquivo, utilizando o ; como caractere delimitador para cada uma das informações abaixo:    
            //Nome, idade, sexo, email, telefone, estado civil, casa propria, valor aluguel            
            //Todas as informações, ficam na mesma linha - cada linha é uma pessoa            
            //Apenas nome, idade e casa propria são campos obrigatórios
            //Verificar se o arquivo existe
            //Ler o arquivo, caso exista, criar um novo com os dados anteriores e os novos inseridos

            //Exemplo do arquivo txt salvo:           
            //Fabrício;21;;;;;Sim;0
            //Joao;25;Masculino;;;;Não;1500
            //Maria;19;Feminino;;;;Sim;0

            string nome;
            do
            {
                Console.WriteLine("Informe o nome:");
                nome = Console.ReadLine();
            } while (ValidarCampos(nome));

            int idade = 0;
            bool idadeValidada;
            do
            {
                try
                {
                    Console.WriteLine("Informe a idade:");
                    idade = int.Parse(Console.ReadLine());
                    idadeValidada = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato inválido, tente novamente.");
                    idadeValidada = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                    idadeValidada = true;
                }
            } while (idadeValidada);

            Console.WriteLine("Informe o sexo:");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe o e-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Informe o telefone:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Informe o estado civil:");
            string estadoCivil = Console.ReadLine();

            int casaPropria = 0;
            bool CasaPropriaValidada;
            do
            {
                try
                {
                    Console.WriteLine("Informe se possui casa propria: (1 - Sim / 2 - Não)");
                    casaPropria = int.Parse(Console.ReadLine());
                    CasaPropriaValidada = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato inválido, tente novamente.");
                    CasaPropriaValidada = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    CasaPropriaValidada = true;
                }

            } while (CasaPropriaValidada);

            double valorAluguel = 0;
            if (casaPropria == 2)
            {
                Console.WriteLine("Informe o valor do aluguel:");
                valorAluguel = double.Parse(Console.ReadLine());
            }

            List<string> linhas = new List<string>();

            if (File.Exists("ExemploEscritaLeituraArquivo.txt"))
            {
                try
                {
                    StreamReader leitor = new StreamReader("ExemploEscritaLeituraArquivo.txt");

                    linhas.Add(leitor.ReadLine());

                    string? linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        linhas.Add(linha);
                    }

                    leitor.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                }              
            }

            linhas.Add(nome + ";" + idade + ";" + sexo + ";" + email + ";" + telefone + ";" + estadoCivil + ";" + (casaPropria == 1 ? "Sim" : "Não") + ";" + valorAluguel);

            try
            {
                StreamWriter escrita = new StreamWriter("ExemploEscritaLeituraArquivo.txt");

                foreach (string linha in linhas)
                {
                    escrita.WriteLine(linha);
                }

                escrita.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }           
        }

        static void Main(string[] args)
        {
            //EscritaArquivo();

            //LeituraArquivo();

            //ExemploEscritaArquivo();

            ExemploEscritaLeituraArquivo();
        }
    }
}