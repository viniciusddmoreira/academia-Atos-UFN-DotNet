namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal abstract class Animal
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }

        protected Animal(string nome, string sexo, string raca)
        {
            Nome = nome;
            Sexo = sexo;
            Raca = raca;
        }

        protected Animal()
        {
        }

        public abstract void EmitirSom();

        public void Dormir()
        {
            Console.WriteLine("Esta dormindo.");
        }

        public void Caminhar()
        {
            Console.WriteLine("Esta caminhando.");
        }

        public string ExibirDados()
        {
            return "Nome: " + Nome + "\nSexo: " + Sexo + "\nRaca: " + Raca + "\n"; 
        }
    }
}
