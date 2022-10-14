namespace ExerciciosAulaListPOO
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;         
        }

        public Pessoa() 
        { 
        }
    }
}
