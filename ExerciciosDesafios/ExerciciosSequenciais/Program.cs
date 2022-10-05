namespace ExerciciosSequenciais
{
    internal class Program
    {
        static void CalcularMediaAritmeticaDoisNumeros()
        {
            Console.WriteLine("Informe o primeiro número:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double b = double.Parse(Console.ReadLine());

            double media = (a + b) / 2;

            Console.WriteLine("A média aritmética entre os dois números é: " + media.ToString("F"));

        }

        static void CalcularMediaAritmeticaQuatroNumeros()
        {

            Console.WriteLine("Informe o primeiro número:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quarto número:");
            double d = double.Parse(Console.ReadLine());

            double media = (a + b + c + d) / 4;

            Console.WriteLine("A média aritmética entre os quatro números é: " + media.ToString("F"));
        }

        static void TrocarValores()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"O valor de A é {a} e o valor de B é {b}.");
                 
            int aux = a;

            a = b;

            b = aux;

            Console.WriteLine($"Os valores das duas variáveis trocados entre si é A = {a} e B = {b}.");
        }

        static void TrocarFormatoData()
        {
            Console.WriteLine("Informe a data no formato DD/MM/AAAA:");
            string dataString = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dataString, "dd/MM/yyyy", null);

            int dia = date.Day;
            int mes = date.Month;
            int ano = date.Year;

            Console.WriteLine($"A data no formato AAAA/MM/DD é: {ano}/{mes}/{dia}." );
            Console.WriteLine($"A data no formato AA/MM/DD é: {ano % 100}/{mes}/{dia}.");

        }

        static void CalcularConsumoMedioAutomovel()
        {
            Console.WriteLine("Informe a distância total percorrida em KM:");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o volume de combustível consumido em litros para percorrer esta distância:");
            double consumo = double.Parse(Console.ReadLine());

            double media = distancia / consumo;

            Console.WriteLine($"O consumo médio do automóvel é de {media.ToString("F")} KM/L.");
        }

        static void AcrescentarIPIParafusos()
        {         
            Console.WriteLine("Informe o código do parafuso A:");
            int codigoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças do parafuso A:");
            int quantidadePecasA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário do parafuso A:");
            double valorUnitarioA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código do parafuso B:");
            int codigoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças do parafuso B:");
            int quantidadePecasB = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário do parafuso B:");
            double valorUnitarioB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual do IPI:");
            double ipi = double.Parse(Console.ReadLine());

            double valorTotalParasufoA = valorUnitarioA * quantidadePecasA + (valorUnitarioA * quantidadePecasA * (ipi / 100));

            double valorTotalParasufoB = valorUnitarioB * quantidadePecasB + (valorUnitarioB * quantidadePecasB * (ipi / 100));

            Console.WriteLine($"O parafuso A de código {codigoA} tem o valor total acrescedido do IPI de {valorTotalParasufoA.ToString("C")}.");
            Console.WriteLine($"O parafuso B de código {codigoB} tem o valor total acrescedido do IPI de {valorTotalParasufoB.ToString("C")}.");

        }

        static void CalcularSalarioTotalVendedor()
        {
            Console.WriteLine("Informe o número do vendedor:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salário fixo:");
            double salarioFixo  = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total vendas efetuadas em reais:");
            double valorTotalDeVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual que ganha sobre o total de vendas:");    
            double percentualSobreVendas = double.Parse(Console.ReadLine());

            double salarioTotal = salarioFixo + (valorTotalDeVendas * percentualSobreVendas / 100);

            Console.WriteLine($"O vendedor de número {codigo} recebe um salário total de {salarioTotal.ToString("C")}.");
        }

        static void ConverterCelsiusFahrenheit()
        {
            Console.WriteLine("Informe a temperatura em Celsius:");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double conversaoParaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            Console.WriteLine($"A temperatura {temperaturaCelsius}ºC convertida para Fahrenheit é {conversaoParaFahrenheit}ºK.");
        }     

        static void CalcularEntradaPrestacoes()
        {
            Console.WriteLine("Informe o valor da mercadoria:");
            double valorMercadoria = double.Parse(Console.ReadLine());

            double valorParcelas = (valorMercadoria - (valorMercadoria % 3)) / 3;

            double valorEntrada = valorParcelas + (valorMercadoria % 3);

            Console.WriteLine($"O valor da entrada é de {valorEntrada.ToString("C")} e o valor das parcelas é de {valorParcelas.ToString("C")}.");
        }

        static void CalcularDistribuicaoDeNotas()
        {
            Console.WriteLine("Informe o valor do saque em reais:");
            int saque = int.Parse(Console.ReadLine());
          
            int quantidadeNotasDeCem = saque / 100;
            saque = saque - (quantidadeNotasDeCem * 100);
           
            int quantidadeNotasDeCinquenta = saque / 50;
            saque = saque - (quantidadeNotasDeCinquenta * 50);

            int quantidadeNotasDeVinte = saque / 20;
            saque = saque - (quantidadeNotasDeVinte * 20);

            int quantidadeNotasDeDez = saque / 10;
            saque = saque - (quantidadeNotasDeDez * 10);

            int quantidadeNotasDeCinco = saque / 5;
            saque = saque - (quantidadeNotasDeCinco * 5);

            int quantidadeNotasDeDois = saque / 2;
            saque = saque - (quantidadeNotasDeDois * 2);

            int quantidadeNotasDeUm = saque / 1;
            saque = saque - (quantidadeNotasDeUm * 1);

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
            Console.WriteLine("Informe o número de eleitores de um município:");
            int quantidadeEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de votos brancos:");
            int quantidadeVotosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de votos nulos:");
            int quantidadeVotosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de votos válidos:");
            int quantidadeVotosValidos = int.Parse(Console.ReadLine());

            double votosBrancos = (quantidadeVotosBrancos / (double)quantidadeEleitores);
            double votosNulos = (quantidadeVotosNulos / (double)quantidadeEleitores);
            double votosValidos = (quantidadeVotosValidos / (double)quantidadeEleitores);

            Console.WriteLine("Votos Brancos: " + votosBrancos.ToString("P"));
            Console.WriteLine("Votos Nulos: " + votosNulos.ToString("P"));
            Console.WriteLine("Votos Válidos: " + votosValidos.ToString("P"));
        }

        static void CalcularMediaConsumoELucroLiquidoDiario()
        {
            Console.WriteLine("Informe a marcação do odômetro (marcador de quilometragem) no início do dia:");
            double marcacaoOdometroInicio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a marcação do odômetro (marcador de quilometragem) no final do dia:");
            double marcacaoOdometroFim = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de litros de combustível gasto:");
            double quantidadeCombustivelGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total em reais recebido dos passageiros:");
            double valorTotalRecebido = double.Parse(Console.ReadLine());

            double totalQuilometragem = marcacaoOdometroFim - marcacaoOdometroInicio;

            double mediaConsumo = totalQuilometragem / quantidadeCombustivelGasto;

            double lucroDia = valorTotalRecebido - (quantidadeCombustivelGasto * 6.90);

            Console.WriteLine($"A média do consumo é de {mediaConsumo.ToString("F")} Km/L e o lucro líquido do dia é de {lucroDia.ToString("C")}.");

        }

        static void CalcularSalarioEmpregado()
        {
            Console.WriteLine("Informe o valor do salário mínimo:");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de custo de cada bicicleta:");
            double precoBicicleta = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de bicicletas vendidas pelo vendedor:");
            double quantidadeBicicletasVendidas = double.Parse(Console.ReadLine());

            double salarioFinal = salarioMinimo * 2 + precoBicicleta * quantidadeBicicletasVendidas * 0.15;

            Console.WriteLine($"O salário final do empregado é de {salarioFinal.ToString("C")}.");
        }

        static void Main(string[] args)
        {
            //Exercício 1
            //CalcularMediaAritmeticaDoisNumeros();

            //Exercício 2
            //CalcularMediaAritmeticaQuatroNumeros();

            //Exercício 3
            //TrocarValores();

            //Exercício 4
            //TrocarFormatoData();

            //Exercício 5
            //CalcularConsumoMedioAutomovel();

            //Exercício 6
            //AcrescentarIPIParafusos();

            //Exercício 7
            //CalcularSalarioTotalVendedor();

            //Exercício 8
            //ConverterCelsiusFahrenheit();        

            //Exercício 9
            //CalcularEntradaPrestacoes();

            //Exercício 10
            //CalcularDistribuicaoDeNotas();

            //Exercício 11
            //CalcularVotosEleitores();

            //Exercício 12
            //CalcularMediaConsumoELucroLiquidoDiario();

            //Exercício 13
            CalcularSalarioEmpregado();
        }
    }
}