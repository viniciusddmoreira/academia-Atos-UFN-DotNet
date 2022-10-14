namespace ExemplosAbstracaoHerancaPOO
{
    internal class Celular : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Android iniciando.");
            Ligado = true;
        }
    }
}
