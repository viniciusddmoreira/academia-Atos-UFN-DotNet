namespace ExemplosAbstracaoHerancaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Televisao televisaoA = new Televisao();

            do
            {
                Console.WriteLine("MENU DE OPÇOES: O que deseja fazer com seu equipamento?");
                Console.WriteLine("1 - Ligar");
                Console.WriteLine("2 - Desligar");
                Console.WriteLine("3 - Verificar status");
                Console.WriteLine("4 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        if (televisaoA.Ligado)
                            Console.WriteLine("Já esta ligado!");
                        else
                            televisaoA.Ligar();
                        break;
                    case 2:
                        if (!televisaoA.Ligado)
                            Console.WriteLine("Já esta desligado!");
                        else
                            televisaoA.Desligar();
                        break;
                    case 3:
                        if (televisaoA.Ligado)
                            Console.WriteLine("Já esta ligado!");
                        else
                            Console.WriteLine("Já esta desligado!");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 4);
        }
    }
}