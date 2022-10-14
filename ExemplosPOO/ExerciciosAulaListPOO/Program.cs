namespace ExerciciosAulaListPOO
{
    internal class Program
    {
        static List<Pessoa> pessoas;

        static void ListaNaoOrdenada()
        {
            Console.WriteLine("\nLista não ordenada:");
            pessoas.ForEach(delegate (Pessoa pessoa) 
            { 
                Console.WriteLine(pessoa.Idade + " " + pessoa.Nome); 
            });
        }

        static void ListaOrdenadaPorNome()
        {
            Console.WriteLine("\nLista ordenada por nome:");

            pessoas.Sort(delegate (Pessoa pessoaA, Pessoa pessoaB)
            {
                return pessoaA.Nome.CompareTo(pessoaB.Nome);
            });

            pessoas.ForEach(delegate (Pessoa pessoa)
            {
                Console.WriteLine(pessoa.Idade + " " + pessoa.Nome);
            });
        }

        static void ListaOrdenadaPorIdade()
        {
            Console.WriteLine("\nLista ordenada por idade:");

            pessoas.Sort(delegate (Pessoa pessoaA, Pessoa pessoaB)
            {
                return pessoaA.Idade.CompareTo(pessoaB.Idade);
            });

            pessoas.ForEach(delegate (Pessoa pessoa)
            {
                Console.WriteLine(pessoa.Idade + " " + pessoa.Nome);
            });
        }

        static void ListaInserirItemNaPosicao()
        {
            Console.WriteLine("\nInserindo uma pessoa na posição 1 e outra pessoa na posição 3");

            pessoas.Insert(1, new Pessoa() { Nome = "Bob Dylan", Idade = 78 });
            pessoas.Insert(3, new Pessoa() { Nome = "Jimmi Page", Idade = 81 });
        }

        static void ListaLocalizaPessoaMaisJovem()
        {
            List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa pessoa) { return pessoa.Idade < 45; });

            Console.WriteLine("\nPessoas que a idade é menor que 45:");

            jovem.ForEach(delegate (Pessoa pessoa)
            {
                Console.WriteLine(pessoa.Idade + " " + pessoa.Nome);
            });
        }

        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(40, "Ricardo"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
            }

            ListaNaoOrdenada();
            ListaOrdenadaPorNome();
            ListaOrdenadaPorIdade();
            ListaInserirItemNaPosicao();
            ListaNaoOrdenada();
            ListaOrdenadaPorNome();
            ListaOrdenadaPorIdade();
            ListaLocalizaPessoaMaisJovem();
        }
    }
}