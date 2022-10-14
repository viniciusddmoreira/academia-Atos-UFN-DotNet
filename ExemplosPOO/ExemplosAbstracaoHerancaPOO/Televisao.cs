namespace ExemplosAbstracaoHerancaPOO
{
    internal class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("WebOS ligando.");
            Ligado = true;
        }
    }
}
