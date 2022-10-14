namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public Cachorro()
        {
        }
       
        public override void EmitirSom()
        {
            Console.WriteLine("Esta latindo.");
        }
    }
}
