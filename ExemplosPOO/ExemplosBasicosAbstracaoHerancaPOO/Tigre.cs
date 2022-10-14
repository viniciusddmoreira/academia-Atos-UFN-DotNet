namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal class Tigre : Animal
    {
        public Tigre(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public Tigre()
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Esta roncando.");
        }
    }
}
