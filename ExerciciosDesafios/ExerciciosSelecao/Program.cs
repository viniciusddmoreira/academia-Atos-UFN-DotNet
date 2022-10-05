namespace ExerciciosSelecao
{
    internal class Program
    {
        static void CalcularAreaTriangulo()
        {
            Console.WriteLine("Informe a base do triângulo em centimetros:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo em centimetros:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            if (baseTriangulo == 0 && alturaTriangulo == 0)
            {
                Console.WriteLine("A base e a altura do triângulo não pode ser igual a zero.");
            }
            else if (alturaTriangulo == 0)
            {
                Console.WriteLine("A altura do triângulo não pode ser igual a zero.");
            }
            else if (baseTriangulo == 0)
            {
                Console.WriteLine("A base do triângulo não pode ser igual a zero.");
            }
            else
            {
                double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine($"A área do triângulo é de {areaTriangulo} cm².");
            }
        }

        static void VerificarParOuImpar()
        {
            Console.WriteLine("Informe um número inteiro para verificar se é par ou ímpar:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número informado é par.");
            }
            else
            {
                Console.WriteLine("O número informado é ímpar.");
            }
        }     

        static void CalcularValoresSuperioresMedia()
        {
            Console.WriteLine("Informe o primeiro valor:");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor:");
            double terceiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quarto valor:");
            double quartoValor = double.Parse(Console.ReadLine());

            double media = (primeiroValor + segundoValor + terceiroValor + quartoValor) / 4;

            Console.WriteLine($"A média dos quatro valores é: {media}.");

            if (primeiroValor > media)
            {
                Console.WriteLine($"O primeiro valor informado é maior que a média dos valores.");
            }
            if (segundoValor > media)
            {
                Console.WriteLine($"O segundo valor informado é maior que a média dos valores.");
            }
            if (terceiroValor > media)
            {
                Console.WriteLine($"O terceiro valor informado é maior que a média dos valores.");
            }
            if (quartoValor > media)
            {
                Console.WriteLine($"O quarto valor informado é maior que a média dos valores.");
            }
        }

        static void CalcularMaiorSalarioProfessores()
        {
            Console.WriteLine("Informe a quantidade de horas de aula dadas pelo primeiro professor:");
            double horasPrimeiro = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em R$ por hora recebido pelo primeiro professor :");
            double valorPrimeiro = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas de aula dadas pelo segundo professor:");
            double horasSegundo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em R$ por hora recebido pelo segundo professor :");
            double valorSegundo = double.Parse(Console.ReadLine());

            double salarioPrimeiro = horasPrimeiro * valorPrimeiro;
            double salarioSegundo = horasSegundo * valorSegundo;

            if (salarioPrimeiro > salarioSegundo)
            {
                Console.WriteLine($"O primeiro professor tem o maior salário, sendo {salarioPrimeiro.ToString("C")}, enquanto o segundo professor tem um salário de {salarioSegundo.ToString("C")}.");
            }
            else if (salarioPrimeiro < salarioSegundo)
            {
                Console.WriteLine($"O segundo professor tem o maior salário, sendo {salarioSegundo.ToString("C")}, enquanto o primeiro professor tem um salário de {salarioPrimeiro.ToString("C")}.");
            }
            else
            {
                Console.WriteLine($"O salário dos dois professores são iguais. Sendo {salarioPrimeiro.ToString("C")}.");
            }

        }

        static void CalcularMediaNotasAluno()
        {
            Console.WriteLine("Informe a primeira nota do aluno:");
            double primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno:");
            double segundaNota = double.Parse(Console.ReadLine());

            double mediaAluno = (primeiraNota + segundaNota) / 2;

            Console.WriteLine($"A média das notas do aluno é {mediaAluno}.");

            if (mediaAluno >= 7)
            {
                Console.WriteLine("O aluno foi aprovado, com a média das notas igual ou superior a 7.");
            }
            else
            {
                Console.WriteLine("A média é inferior a 7, informe a nota do exame do aluno:");
                double notaExame = double.Parse(Console.ReadLine());

                double mediaExameAluno = (mediaAluno + notaExame) / 2;

                Console.WriteLine($"A nota final do aluno é {mediaExameAluno}.");

                if (mediaExameAluno >= 5)
                {
                    Console.WriteLine("O aluno que estava de exame foi aprovado, com a nota final superior ou igual a 5.");
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado, com a nota final inferior a 5.");
                }
            }
        }

        static void CalcularIMC()
        {
            Console.WriteLine("Informe o nome da pessoa (totalmente em maiúsculo):");
            string nome = Console.ReadLine();

            if (nome != nome.ToUpper())
            {
                Console.WriteLine("O nome da pessoa informada deve ser totalmente em caracteres maiúsculos.");
            }
            else
            {
                Console.WriteLine("Informe a altura em metros da pessoa:");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o peso em kg da pessoa:");
                double peso = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                if (imc < 18)
                {
                    Console.WriteLine("A pessoa esta a baixo do peso.");
                }
                else if (imc > 18 && imc < 25)
                {
                    Console.WriteLine("A pessoa esta no peso ideal.");
                }
                else if (imc > 25 && imc < 30)
                {
                    Console.WriteLine("A pessoa esta com sobrepeso.");
                }
                else if (imc > 30 && imc < 35)
                {
                    Console.WriteLine("A pessoa esta com obesidade.");
                }
                else
                {
                    Console.WriteLine("A pessoa esta com obesidade grau sério.");
                }
            }
        }

        static void EncontrarPalavra()
        {
            Console.WriteLine("Informe uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Informe a palavra a ser verificada se esta contida na frase informada:");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase informada.");
            }
            else
            {
                Console.WriteLine("A palavra não encontra-se na frase informada.");
            }
        }

        static void CalcularSalarioFuncionario()
        {
            Console.WriteLine("Informe o código do funcionário:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o salário base do funcionário:");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas do funcionário em R$:");
            double totalVendas = double.Parse(Console.ReadLine());

            double salarioFinal;
        
            if (totalVendas > 5000)
            {
                salarioFinal = salarioBase + totalVendas + (totalVendas * 0.10);
            }
            else if (totalVendas > 1000)
            {
                salarioFinal = salarioBase + totalVendas + (totalVendas * 0.07);
            }
            else if (totalVendas > 500)
            {
                salarioFinal = salarioBase + totalVendas + (totalVendas * 0.05);
            }
            else
            {
                salarioFinal = salarioBase + totalVendas;
            }

            Console.WriteLine($"O funcionário de código {codigo} e nome {nome}, tem um salário total de {salarioFinal.ToString("C")}.");
        }

        static void CalcularGlicemia()
        {
            Console.WriteLine("Informe o primeiro valor referente a medição diária de glicemia em jejum do paciente:");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor referente a medição diária de glicemia em jejum do paciente:");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor referente a medição diária de glicemia em jejum do paciente:");
            double terceiroValor = double.Parse(Console.ReadLine());

            if (primeiroValor > 250)
            {
                Console.WriteLine("O paciente corre o risco de hiperglicemia com a primeira medida informada.");
            }
            else if (primeiroValor < 65)
            {
                Console.WriteLine("O paciente corre o risco de hipoglicemia com a primeira medida informada.");
            }
            else
            {
                Console.WriteLine("O paciente encontra-se estável na primeira medida informada.");
            }

            if (segundoValor > 250)
            {
                Console.WriteLine("O paciente corre o risco de hiperglicemia com a segunda medida informada.");
            }
            else if (segundoValor < 65)
            {
                Console.WriteLine("O paciente corre o risco de hipoglicemia com a segunda medida informada.");
            }
            else
            {
                Console.WriteLine("O paciente encontra-se estável na segunda medida informada.");
            }

            if (terceiroValor > 250)
            {
                Console.WriteLine("O paciente corre o risco de hiperglicemia com a terceira medida informada.");
            }
            else if (terceiroValor < 65)
            {
                Console.WriteLine("O paciente corre o risco de hipoglicemia com a terceira medida informada.");
            }
            else
            {
                Console.WriteLine("O paciente encontra-se estável na terceira medida informada.");
            }

            double mediaGlicemia = (primeiroValor + segundoValor + terceiroValor) / 3;

            if (mediaGlicemia < 80)
            {
                Console.WriteLine("O paciente deve diminuir 2 unidades de insulina.");
            }
            else if (mediaGlicemia > 150)
            {
                Console.WriteLine("O paciente deve aumentar 2 unidades de insulina.");
            }
            else
            {
                Console.WriteLine("A média de glicemia do paciente encontra-se estável.");
            }
        }

        static void VerificarAtletaNovoAlto()
        {
            Console.WriteLine("Informe o nome do primeiro atleta:");
            string nomePrimeiro = Console.ReadLine();

            Console.WriteLine("Informe a idade do primeiro atleta:");
            int idadePrimeiro = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do primeiro atleta:");
            double alturaPrimeiro = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do segundo atleta:");
            string nomeSegundo = Console.ReadLine();

            Console.WriteLine("Informe a idade do segundo atleta:");
            int idadeSegundo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do segundo atleta:");
            double alturaSegundo = double.Parse(Console.ReadLine());

            if (idadePrimeiro < idadeSegundo && alturaPrimeiro > alturaSegundo)
            {
                Console.WriteLine($"O atleta mais novo e mais alto é o(a) {nomePrimeiro}, com {idadePrimeiro} anos e {alturaPrimeiro} de altura.");
            }
            else if (idadePrimeiro > idadeSegundo && alturaPrimeiro < alturaSegundo)
            {
                Console.WriteLine($"O atleta mais novo e mais alto é o(a) {nomeSegundo}, com {idadeSegundo} anos e {alturaSegundo} de altura.");
            }
            else
            {
                Console.WriteLine("Nenhum dos dois atletas possui ambas as características de mais novo e mais alto comparados entre si.");
            }
        }

        static void ValidarHora()
        {
            Console.WriteLine("Informe a hora (00:00):");
            string horaCompleta = Console.ReadLine();

            int hora = int.Parse(horaCompleta.Substring(0, 2));
            int minutos = int.Parse(horaCompleta.Substring(3, 2));

            if (hora < 0 || hora > 23 || minutos < 0 || minutos > 59)
            {
                Console.WriteLine("A hora informada é inválida.");
            }
            else
            {
                Console.WriteLine($"A hora informada é {hora} hora(s) e {minutos} minuto(s).");
            }

        }

        static void CalcularSalarioTotalSalarioExcedente()
        {
            Console.WriteLine("Informe o código do operário:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas pelo operário:");
            double numeroHoras = double.Parse(Console.ReadLine());
           
            double salarioExcedente = 0;
            double salarioTotal;

            if (numeroHoras > 50)
            {
                double horaExtra = numeroHoras - 50;
                salarioExcedente = horaExtra * 20;
                salarioTotal = (numeroHoras - horaExtra) * 10 + salarioExcedente;               
            }
            else
            {
                salarioTotal = numeroHoras * 10;

            }

            Console.WriteLine($"O operário de código {codigo} recebe um salário total de {salarioTotal.ToString("C")} e um salário excedente de {salarioExcedente.ToString("C")}.");
            
        }         

        static void CalcularPesoIdeal()
        {
            Console.WriteLine("Informe a altura da pessoa:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo (M: masculino / F: feminino) da pessoa:");
            string sexo = (Console.ReadLine());


            if (sexo.Equals("M", StringComparison.OrdinalIgnoreCase))
            {
                double pesoIdealHomem = (72.7 * altura) - 58;
                Console.WriteLine($"O peso idela do homem é {pesoIdealHomem.ToString("F")}.");
            }
            else if (sexo.Equals("F", StringComparison.OrdinalIgnoreCase))
            {
                double pesoIdealMulher = (62.1 * altura) - 44.7;
                Console.WriteLine($"O peso ideal da mulher é {pesoIdealMulher.ToString("F")}.");
            }
            else
            {
                Console.WriteLine("O caracter informado é inválido.");
            }
        }

        static void CalcularTempoDownload()
        {
            Console.WriteLine("Informe o tamanho do arquivo para download (em MB):");
            double tamanhoArquivo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade do link de internet (em Mbps):");
            double velocidadeInternet = double.Parse(Console.ReadLine());

            double tempoDownload = (tamanhoArquivo / (velocidadeInternet / 8)) / 60;

            Console.WriteLine($"O tempo aproximado de download é de {tempoDownload.ToString("F")} minutos.");
        }

        static void CalcularLatasDeTintaPrecoTotal()
        {
            Console.WriteLine("Informe o tamanho em metros quadrados da área a ser pintada:");
            double area = double.Parse(Console.ReadLine());

            double quantidadeLitrosGasto = area / 3;

            double quantidadeDeLatas = Math.Ceiling(quantidadeLitrosGasto / 18);

            double precoTotal = quantidadeDeLatas * 80;

            Console.WriteLine($"Será necessario comprar {quantidadeDeLatas} lata(s) e o preço total é de {precoTotal.ToString("C")}.");

        }

        static void ClassificarTimeFutebol()
        {
            Console.WriteLine("Informe a quantidade de gols do time da casa:");
            int timeDaCasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de gols do time de fora:");
            int timeDeFora = int.Parse(Console.ReadLine());

            if (timeDeFora - timeDaCasa >= 2)
            {
                Console.WriteLine("O time de fora já se classificou.");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");

                Console.WriteLine("Informe a quantidade de gols do time da casa no novo jogo:");
                timeDaCasa = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de gols do time de fora no novo jogo:");
                timeDeFora = int.Parse(Console.ReadLine());

                if(timeDeFora - timeDaCasa > 0)
                {
                    Console.WriteLine("O time de fora passou de fase.");
                }
                else if (timeDaCasa - timeDeFora > 0)
                {
                    Console.WriteLine("O time da casa passou de fase.");
                }
                else
                {
                    Console.WriteLine("Houve um empate no novo jogo entre os times.");
                }
            }
        }

        static void ClassificarTriangulo()
        {
            Console.WriteLine("Entre com o primeiro lado do triângulo:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo lado do triângulo:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro lado do triângulo:");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }

        }

        static void VerificarMaiorValor()
        {
            Console.WriteLine("Informe o primeiro valor:");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor:");
            double terceiroValor = double.Parse(Console.ReadLine());

            if(primeiroValor > segundoValor && primeiroValor > terceiroValor)
            {
                Console.WriteLine("O primeiro valor informado é o maior.");
            }
            else if (segundoValor > primeiroValor && segundoValor > terceiroValor)
            {
                Console.WriteLine("O segundo valor informado é o maior.");
            }
            else
            {
                Console.WriteLine("O terceiro valor informado é o maior.");
            }
        }

        static void ExibirValoresOrdemCrescente()
        {
            Console.WriteLine("Informe o primeiro valor:");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor:");
            double terceiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Valores em ordem crescente:");

            if (primeiroValor < segundoValor && primeiroValor < terceiroValor)
            {
                Console.WriteLine(primeiroValor);
            }
            else if (segundoValor < primeiroValor && segundoValor < terceiroValor)
            {
                Console.WriteLine(segundoValor);
            }
            else
            {
                Console.WriteLine(terceiroValor);
            }
          
            if (primeiroValor > segundoValor && primeiroValor < terceiroValor)
            {
                Console.WriteLine(primeiroValor);
            }
            else if (primeiroValor < segundoValor && primeiroValor > terceiroValor)
            {
                Console.WriteLine(primeiroValor);
            }
            else if (segundoValor > primeiroValor && segundoValor < terceiroValor)
            {
                Console.WriteLine(segundoValor);
            }
            else if (segundoValor < primeiroValor && segundoValor > terceiroValor)
            {
                Console.WriteLine(segundoValor);
            }
            else
            {
                Console.WriteLine(terceiroValor);
            }

            if (primeiroValor > segundoValor && primeiroValor > terceiroValor)
            {
                Console.WriteLine(primeiroValor);
            }
            else if (segundoValor > primeiroValor && segundoValor > terceiroValor)
            {
                Console.WriteLine(segundoValor);
            }
            else
            {
                Console.WriteLine(terceiroValor);
            }
        }

        static void AdivinharNumeroAleatorio()
        {

            Random numeroAleatorio = new Random();
            int valorInteiroGerado = numeroAleatorio.Next(0,10);

            Console.WriteLine("Informe um valor para adivinhar o número secreto entre 0 e 10:");
            int numero = int.Parse(Console.ReadLine());

            if (numero == valorInteiroGerado)
            {
                Console.WriteLine("Acertou!");
            }
            else
            {
                if (numero > valorInteiroGerado)
                { 
                    Console.WriteLine("O número secreto é menor.");
                }
                else
                {
                    Console.WriteLine("O número secreto é maior.");
                }

                Console.WriteLine("Informe novamente um valor para adivinhar o número secreto entre 0 e 10:");
                numero = int.Parse(Console.ReadLine());

                if (numero == valorInteiroGerado)
                {
                    Console.WriteLine("Acertou!");
                }
                else
                {
                    if (numero > valorInteiroGerado)
                    {
                        Console.WriteLine("O número secreto é menor.");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é maior.");
                    }

                    Console.WriteLine("Informe novamente um valor para adivinhar o número secreto entre 0 e 10:");
                    numero = int.Parse(Console.ReadLine());

                    if (numero == valorInteiroGerado)
                    {
                        Console.WriteLine("Acertou!");
                    }
                    else
                    {
                        Console.WriteLine("Você errou as 3 tentativas.");                     
                    }
                }
            }

            Console.WriteLine($"O número secreto é: {valorInteiroGerado}.");
        }

        static void Main(string[] args)
        {
            //Exercício 1
            //CalcularAreaTriangulo();

            //Exercício 2
            //VerificarParOuImpar();          

            //Exercício 3
            //CalcularValoresSuperioresMedia();

            //Exercício 4
            //CalcularMaiorSalarioProfessores();

            //Exercício 5
            //CalcularMediaNotasAluno();

            //Exercício 6
            //CalcularIMC();

            //Exercício 7
            //EncontrarPalavra();

            //Exercício 8
            //CalcularSalarioFuncionario();

            //Exercício 9
            //CalcularGlicemia();

            //Exercício 10
            //VerificarAtletaNovoAlto();

            //Exercício 11
            //ValidarHora();

            //Exercício 12
            //CalcularSalarioTotalSalarioExcedente();          

            //Exercício 13
            //CalcularPesoIdeal();

            //Exercício 14
            //CalcularTempoDownload();

            //Exercício 15
            //CalcularLatasDeTintaPrecoTotal();

            //Exercício 16
            //ClassificarTimeFutebol();

            //Exercício 17
            //ClassificarTriangulo();

            //Exercício 18
            //VerificarMaiorValor();

            //Exercício 19
            //ExibirValoresOrdemCrescente();

            //Exercício 20
            AdivinharNumeroAleatorio();
        }
    }
}