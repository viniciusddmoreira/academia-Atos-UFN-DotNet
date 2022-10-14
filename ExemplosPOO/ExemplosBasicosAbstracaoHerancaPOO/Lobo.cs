namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal class Lobo : Animal
    {
        public Lobo(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public Lobo()
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Esta uivando.");
        }
    }
}
