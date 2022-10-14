namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal class Leao : Animal
    {    
        public Leao(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }
        public Leao()
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Esta rugindo.");
        }
    }
}
