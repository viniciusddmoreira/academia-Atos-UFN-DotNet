namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal class Gato : Animal
    {
        public Gato(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public Gato()
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Esta miando.");
        }
    }
}
