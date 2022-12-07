using System.Linq;
using System.Net.Http.Headers;

namespace ExerciciosRepeticao
{
    internal class Program
    {
        static void CalcularNumerosParesNoIntervalo()
        {
            int numero;

            do
            {
                Console.WriteLine("Informe um número inteiro positivo:");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1)             
                    Console.WriteLine("Valor incorreto!");
                   
            } while (numero < 1);

            Console.Write($"Números inteiros pares entre 1 e {numero}: ");
            
            for(int i = 1; i <= numero; i++)
            {
                if(i % 2 == 0)
                {
                    if (i != numero && i != (numero - 1))
                    {
                        Console.Write(i + ", ");
                    }
                    else
                    {
                        Console.Write(i + ".");
                    }                                
                }
            }
        }

        static void CalcularNumerosParesNoIntervaloRepetindo()
        {
            int numero;
            string opcao;

            do
            {
                do
                {
                    Console.WriteLine("Informe um número inteiro positivo:");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 1)
                        Console.WriteLine("Valor incorreto!");

                } while (numero < 1);

                Console.Write($"Números inteiros pares entre 1 e {numero}: ");

                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i != numero && i != (numero - 1))
                        {
                            Console.Write(i + ", ");
                        }
                        else
                        {
                            Console.Write(i + ".");
                        }
                    }
                }

                Console.WriteLine("\nDeseja informar outro número (s/n)?");
                opcao = Console.ReadLine();

            } while (opcao.Equals("S", StringComparison.OrdinalIgnoreCase));         
        }

        static void CalcularParImparPrimo()
        {
            int numero;           

            do
            {
                Console.WriteLine("Informe um número:");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                   continue;

                if(numero % 2 == 0)
                {
                    Console.WriteLine("O número informado é par.");
                }
                else
                {
                    Console.WriteLine("O número informado é ímpar.");
                }

                int quantidadeDivisoes = 0;

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                        quantidadeDivisoes++;
                }

                if (quantidadeDivisoes == 2)
                {
                    Console.WriteLine("O número informado é primo.");
                }
                else
                {
                    Console.WriteLine("O número informado não é primo.");
                }                

            } while (numero != 0);
        }

        static void CalcularNumeroVotos()
        {
            string voto = "";
            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;

            do
            {
                Console.WriteLine("Informe a opção de voto:");
                Console.WriteLine("JOAO - Candidato Joao.");
                Console.WriteLine("ZECA - Candidato Zeca");
                Console.WriteLine("BRANCO - Voto em branco.");
                Console.WriteLine("FIM - Sair");
                voto = Console.ReadLine();
                
                switch (voto.ToUpper())
                {
                    case "JOAO":
                        votosJoao++;
                        break;
                    case "ZECA":
                        votosZeca++;
                        break;
                    case "BRANCO":
                        votosBranco++;
                        break;
                    case "FIM":
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (!voto.Equals("FIM", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Número de votos no Joao: " + votosJoao);
            Console.WriteLine("Número de votos no Zeca: " + votosZeca);
            Console.WriteLine("Número de votos em Branco: " + votosBranco);

        }

        static void CalcularNumeroVotosComNulos()
        {
            string voto = "";
            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;

            do
            {
                Console.WriteLine("Informe a opção de voto:");
                Console.WriteLine("JOAO - Candidato Joao.");
                Console.WriteLine("ZECA - Candidato Zeca");
                Console.WriteLine("BRANCO - Voto em branco.");
                Console.WriteLine("FIM - Sair");
                voto = Console.ReadLine();

                switch (voto.ToUpper())
                {
                    case "JOAO":
                        votosJoao++;
                        break;
                    case "ZECA":
                        votosZeca++;
                        break;
                    case "BRANCO":
                        votosBranco++;
                        break;
                    case "FIM":
                        break;
                    default:
                        votosNulos++;
                        break;
                }
            } while (!voto.Equals("FIM", StringComparison.OrdinalIgnoreCase));

            if (votosJoao == votosZeca)         
                Console.WriteLine("Houve um empate entre os dois candidatos.");
            else if (votosJoao > votosBranco)
                Console.WriteLine("O candidato Joao venceu as eleições.");          
            else
                Console.WriteLine("O candidato Zeca venceu as eleições.");
          
            Console.WriteLine("Número de votos Nulos: {0}.", votosNulos);
            Console.WriteLine($"Número de pessoas que votaram: {votosJoao + votosZeca + votosBranco + votosNulos}.");
        }

        static void ValidarIdade()
        {
            int idade;
            do
            {
                Console.WriteLine("Informe a idade do usuário:");
                idade = int.Parse(Console.ReadLine());

                if(idade < 1)
                    Console.WriteLine("Valor informado inválido. A idade informada deve ser maior que zero.");

            } while (idade < 1);

            Console.WriteLine($"A idade informada é {idade} ano(s).");
        }

        static void ValidarNomeIdadeSalario()
        {
            string nome;
            int idade;
            double salario;

            while (true)
            {
                Console.WriteLine("Informe o nome do usuário:");
                nome = Console.ReadLine();

               
                
            }
        }

        static void Main(string[] args)
        {
            //Exercício 1
            //CalcularNumerosParesNoIntervalo();

            //Exercício 2
            //CalcularNumerosParesNoIntervaloRepetindo();

            //Exercício 3
            //CalcularParImparPrimo();

            //Exercício 4
            //CalcularNumeroVotos();

            //Exercício 5
            //CalcularNumeroVotosComNulos();

            //Exercício 6
            //ValidarIdade();
        }
    }
}