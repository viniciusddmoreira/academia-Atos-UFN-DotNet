namespace ExemplosAbstracaoHerancaPOO
{
    internal class PlayStation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o PlayStation.");
            Ligado = true;
        }
    }
}
