namespace ExemplosGetSetPOO
{
    internal class Program
    {
        static void ExemploConta()
        {
            Cliente clienteA = new Cliente();
            clienteA.nome = "Vinícius Daniel";
            clienteA.idade = 27;

            Conta contaA = new Conta(clienteA, 99999, "Corrente");           

            while (true)
            {
                Console.WriteLine("\n1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do saque:");
                        contaA.Debitar(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do deposito:");
                        contaA.Creditar(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("O saldo é de " + contaA.GetSaldo().ToString("C"));
                        break;
                    default:
                        Console.WriteLine("O cliente " + contaA.cliente.nome + " possui saldo de " + contaA.GetSaldo().ToString("C"));
                        return;
                }
            }
        }

        static void ExemploTemperatura()
        {
            Temperatura temperaturaA = new Temperatura();

            Console.WriteLine("Informe uma temperatura em Fahrenheit:");      
            temperaturaA.SetCelsius(double.Parse(Console.ReadLine()));

            Console.WriteLine("---------");
            Console.WriteLine(temperaturaA.GetCelsius());
        }

        static void ExemploCarro()
        {
            Carro carro = new Carro();

            carro.Ligar();

            //carro.ligado = true;
            //carro.ligado = false;

            //carro.cor = "Azul";
            carro.SetCor("Azul");
            Console.WriteLine(carro.GetCor());

            //carro.Modelo = "";

            //carro.VelocidadeMax = 100;

            //carro.Placa = "ABC-1234";

            //string placaCarro = carro.Placa;        

            bool status = carro.GetLigado();

            if (status)
            {
                Console.WriteLine("O carro esta ligado");
            }
            else
            {
                Console.WriteLine("O carro esta desligado");
            }
        }

        static void Main(string[] args)
        {
            //ExemploCarro();

            //ExemploTemperatura();

            ExemploConta();
        }
    }
}