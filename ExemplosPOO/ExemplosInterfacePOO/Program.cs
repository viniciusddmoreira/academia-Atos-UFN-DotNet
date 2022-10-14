namespace ExemplosInterfacePOO
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine("\nMENU DE OPÇOES: O que deseja fazer com seu equipamento?");
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Desligar");
            Console.WriteLine("3 - Verificar status");
            Console.WriteLine("4 - Voltar ao menu anterior");

            return int.Parse(Console.ReadLine());

        }

        static void Main(string[] args)
        {
            int opcao;
            Televisao televisaoA = new Televisao();
            Celular celularA = new Celular();

            do
            {
                Console.WriteLine("MENU DE OPÇOES: Escolha o equipamento.");
                Console.WriteLine("1 - Televisão");
                Console.WriteLine("2 - Celular");
                Console.WriteLine("3 - Sair");

                opcao = int.Parse(Console.ReadLine());              

                switch (opcao)
                {
                    case 1:
                        do
                        {
                            opcao = Menu();
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
                                        Console.WriteLine("Esta ligado!");
                                    else
                                        Console.WriteLine("Esta desligado!");
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida, tente novamente.");
                                    break;
                            }
                        } while (opcao != 4);                        
                        break;
                    case 2:
                        do
                        {
                            opcao = Menu();
                            switch (opcao)
                            {
                                case 1:
                                    if (celularA.Ligado)
                                        Console.WriteLine("Já esta ligado!");
                                    else
                                        celularA.Ligar();
                                    break;
                                case 2:
                                    if (!celularA.Ligado)
                                        Console.WriteLine("Já esta desligado!");
                                    else
                                        celularA.Desligar();
                                    break;
                                case 3:
                                    if (celularA.Ligado)
                                        Console.WriteLine("Esta ligado!");
                                    else
                                        Console.WriteLine("Esta desligado!");
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida, tente novamente.");
                                    break;
                            }
                        } while (opcao != 4);                       
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 3);
        }
    }
}