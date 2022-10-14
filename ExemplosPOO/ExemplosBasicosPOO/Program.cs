namespace ExemplosBasicosPOO
{
    internal class Program
    {
        static void ExemploLampada()
        {
            Lampada lampadaA = new Lampada();

            lampadaA.Ligar();
            Console.WriteLine("Status da lâmpada: " + lampadaA.EstaLigada());
            lampadaA.Desligar();
            Console.WriteLine("Status da lâmpada: " + lampadaA.EstaLigada());
        }

        static void ExemploAviao()
        {
            Aviao aviaoA = new Aviao();
            aviaoA.marca = "AirBus";
            aviaoA.modelo = "A330";
            Console.WriteLine(aviaoA.RetornarDados());

            aviaoA.Acelerar(200);
            Console.WriteLine("Velocidade atual: " + aviaoA.VerificarVelocidade());

            aviaoA.Reduzir(50);
            Console.WriteLine("Velocidade atual: " + aviaoA.VerificarVelocidade());

            aviaoA.Subir(1000);
            Console.WriteLine("Altitude atual: " + aviaoA.VerificarAltitude());

            aviaoA.Descer(200);
            Console.WriteLine("Altitude atual: " + aviaoA.VerificarAltitude());
        }

        static void ExemploContaBancaria()
        {
            ContaBancaria contaA = new ContaBancaria();
            contaA.agencia = "222-X";
            contaA.tipo = "Conta Corrente";
            contaA.conta = "25543-2";
            Console.WriteLine(contaA.RetornaDados());

            contaA.Depositar(1000);
            Console.WriteLine(contaA.ConsultarSaldo()); 

            contaA.Sacar(500);
            Console.WriteLine(contaA.ConsultarSaldo());        

            ContaBancaria contaB = new ContaBancaria("123-Y", "Conta Poupança", 5000, "42340-1");
            Console.WriteLine(contaB.RetornaDados());
            Console.WriteLine(contaB.ConsultarSaldo());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Apresentando classes, objetos, métodos e orientação a objetos básica:");
           
            //ExemploLampada();
            //ExemploAviao();
            ExemploContaBancaria();                    
        }
    }
}