using System;

namespace ExerciciosSequenciais
{
    internal class Program
    {
        static void CalcularMediaAritmeticaDoisNumeros()
        {

            Console.WriteLine("Entre com o primeiro número:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número:");
            double b = double.Parse(Console.ReadLine());

            double resultado = (a + b) / 2;

            Console.WriteLine("A média aritmética entre os dois números é: " + resultado);

        }

        static void CalcularMediaAritmeticaQuatroNumeros()
        {

            Console.WriteLine("Entre com o primeiro número:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro número:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o quarto número:");
            double d = double.Parse(Console.ReadLine());

            double resultado = (a + b + c + d) / 4;

            Console.WriteLine("A média aritmética entre os quatro números é: " + resultado);
        }

        static void TrocarValores()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"O valor é A é {a} e o valor de B é {b}.");
                 
            int c = a;

            a = b;

            b = c;

            Console.WriteLine($"Os valores das duas variáveis trocados entre si é A igual a {a} e de B igual a {b}.");
        }

        static void TrocarFormatoData()
        {
            Console.WriteLine("Entre com a data no formato DD/MM/AAAA:");
            string dataString = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dataString, "dd/MM/yyyy", null);

            int dia = date.Day;
            int mes = date.Month;
            int ano = date.Year;

            Console.WriteLine($"A data na forma AAAA/MM/DD é: {ano}/{mes}/{dia}." );
            Console.WriteLine($"A data na forma AA/MM/DD é: {ano % 100}/{mes}/{dia}.");

        }

        static void CalcularConsumoMedioAutomovel()
        {
            Console.WriteLine("Entre com a distância total percorrida em KM:");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o volume de combustível consumido em litros para percorrer esta distancia:");
            double consumo = double.Parse(Console.ReadLine());

            double media = distancia / consumo;

            Console.WriteLine($"O consumo médio do automóvel é de {media} KM/L.");
        }

        static void AcrescentarIPIParafusos()
        {
            
            Console.WriteLine("Entre com o código do parafuso A:");
            int codigoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade de peças do parafuso A:");
            int quantidadePecasA = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor unitário do parafuso A:");
            double valorUnitarioA = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o código do parafuso B:");
            int codigoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade de peças do parafuso B:");
            int quantidadePecasB = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor unitário do parafuso B:");
            double valorUnitarioB = double.Parse(Console.ReadLine());

            double ipi = 1.20;

            double resultadoA = valorUnitarioA * quantidadePecasA * ipi;

            double resultadoB = valorUnitarioB * quantidadePecasB * ipi;

            Console.WriteLine($"O código do parafuso A é: {codigoA} e o valor total acrescedido do IPI é: {resultadoA}.");
            Console.WriteLine($"O código do parafuso B é: {codigoB} e o valor total acrescedido do IPI é: {resultadoB}.");

        }

        static void CalcularSalarioTotalVendedor()
        {
            Console.WriteLine("Entre com o número do vendedor:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu salário fixo:");
            double salarioFixo  = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor total vendas efetuadas em reais:");
            double valorTotalDeVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o percentual que ganha sobre o total de vendas:");    
            double percentualSobreVendas = double.Parse(Console.ReadLine());

            double salarioTotal = salarioFixo + (valorTotalDeVendas * percentualSobreVendas / 100);

            Console.WriteLine($"O número do vendedor é {codigo} e o salário total é de: R$ {salarioTotal}.");
        }

        static void ConverterCelsiusFahrenheit()
        {
            Console.WriteLine("Entre com a temperatura em Celsius:");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double conversaoParaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            Console.WriteLine($"A temperatura {temperaturaCelsius}ºC convertida para Fahrenheit é {conversaoParaFahrenheit}ºK.");
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
                if ( a == b && b == c)
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

        static void CalcularEntradaPrestacoes()
        {
            Console.WriteLine("Entre com o valor da mercadoria:");
            double valorMercadoria = double.Parse(Console.ReadLine());

            double valorParcelas = (valorMercadoria - (valorMercadoria % 3)) / 3;

            double valorEntrada = valorParcelas + (valorMercadoria % 3);

            Console.WriteLine($"Valor da entrada é de R${valorEntrada} e o valor das parcelas é de R${valorParcelas}.");
        }

        static void DistribuicaoDeNotasCaixaEletronico()
        {
            Console.WriteLine("Entre com o valor do saque em reais:");
            int saque = int.Parse(Console.ReadLine());

            
            int quantidadeNotasDeCem = saque / 100;
            int restanteSaque = saque - (quantidadeNotasDeCem * 100);
           
            int quantidadeNotasDeCinquenta = restanteSaque / 50;
            restanteSaque = restanteSaque - (quantidadeNotasDeCinquenta * 50);

            int quantidadeNotasDeVinte = restanteSaque / 20;
            restanteSaque = restanteSaque - (quantidadeNotasDeVinte * 20);

            int quantidadeNotasDeDez = restanteSaque / 10;
            restanteSaque = restanteSaque - (quantidadeNotasDeDez * 10);

            int quantidadeNotasDeCinco = restanteSaque / 5;
            restanteSaque = restanteSaque - (quantidadeNotasDeCinco * 5);

            int quantidadeNotasDeDois = restanteSaque / 2;
            restanteSaque = restanteSaque - (quantidadeNotasDeDois * 2);

            int quantidadeNotasDeUm = restanteSaque / 1;
            restanteSaque = restanteSaque - (quantidadeNotasDeUm * 1);

            Console.WriteLine($"Distribuição de notas:");
            Console.WriteLine($"{quantidadeNotasDeCem} notas de R$100,00.");
            Console.WriteLine($"{quantidadeNotasDeCinquenta} notas de R$50,00.");
            Console.WriteLine($"{quantidadeNotasDeVinte} notas de R$20,00.");
            Console.WriteLine($"{quantidadeNotasDeDez} notas de R$10,00.");
            Console.WriteLine($"{quantidadeNotasDeCinco} notas de R$5,00.");
            Console.WriteLine($"{quantidadeNotasDeDois} notas de R$2,00.");
            Console.WriteLine($"{quantidadeNotasDeUm} notas de R$1,00.");

        }

        static void CalcularVotosEleitores()
        {
            Console.WriteLine("Digite o número de eleitores de um município:");
            int quantidadeEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos brancos:");
            double quantidadeVotosBrancos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos:");
            double quantidadeVotosNulos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos:");
            double quantidadeVotosValidos = double.Parse(Console.ReadLine());

            Console.WriteLine($"Votos Brancos:{(quantidadeVotosBrancos / quantidadeEleitores) * 100} %");
            Console.WriteLine($"Votos Nulos:{(quantidadeVotosNulos / quantidadeEleitores) * 100} %");
            Console.WriteLine($"Votos Válidos:{(quantidadeVotosValidos / quantidadeEleitores) * 100} %");


        }

        static void CalcularMediaConsumoELucroLiquidoDiario()
        {
            Console.WriteLine("Entre com a marcação do odômetro (marcador de quilometragem) no início do dia:");
            double marcacaoOdometroInicio = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a marcação do odômetro (marcador de quilometragem) no final do dia:");
            double marcacaoOdometroFim = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o número de litros de combustível gasto:");
            double quantidadeCombustivelGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor total (R$) recebido dos passageiros:");
            double valorTotalRecebido = double.Parse(Console.ReadLine());


            double totalQuilometragem = marcacaoOdometroFim - marcacaoOdometroInicio;

            double mediaConsumo = totalQuilometragem / quantidadeCombustivelGasto;

            double lucroDia = valorTotalRecebido - (quantidadeCombustivelGasto * 6.90);

            Console.WriteLine($"A média do consumo é de {mediaConsumo} Km/L e o lucro líquido do dia é de R$ {lucroDia}.");

        }

        static void CalcularSalarioEmpregado()
        {
            Console.WriteLine("Digite o valor do salário mínimo:");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço de custo de cada bicicleta:");
            double precoBicicleta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de bicicletas vendidas pelo vendedor:");
            double quantidadeBicicletasVendidas = double.Parse(Console.ReadLine());

            double salarioFinal = salarioMinimo * 2 + precoBicicleta * quantidadeBicicletasVendidas * 0.15;

            Console.WriteLine($"O salário final do empregado é de R$ {salarioFinal}.");
        }
        static void Main(string[] args)
        {
            // Exercício 1
            //CalcularMediaAritmeticaDoisNumeros();

            // Exercício 2
            //CalcularMediaAritmeticaQuatroNumeros();

            // Exercício 3
            //TrocarValores();

            // Exercício 4
            //TrocarFormatoData();

            // Exercício 5
            //CalcularConsumoMedioAutomovel();

            // Exercício 6
            //AcrescentarIPIParafusos();

            // Exercício 7
            //CalcularSalarioTotalVendedor();

            // Exercício 8
            //ConverterCelsiusFahrenheit();        

            // Exercício 9
            //CalcularEntradaPrestacoes();

            // Exercício 10
            //DistribuicaoDeNotasCaixaEletronico();

            // Exercício 11
            //CalcularVotosEleitores();

            // Exercício 12
            //CalcularMediaConsumoELucroLiquidoDiario();

            // Exercício 13
            //CalcularSalarioEmpregado();

            // Exercício feito em aula
            //ClassificarTriangulo();
        }
    }
}