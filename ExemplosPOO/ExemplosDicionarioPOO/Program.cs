using System.Runtime.CompilerServices;

namespace ExemplosDicionarioPOO
{

    
    internal class Program
    {
        static void CriandoUmDicionarioOrdenado()
        {
            //Criando um dicionario ordenado
            SortedDictionary<string, int> dicionarioD = new SortedDictionary<string, int>();

            //Adicionando strings e chaves do tipo int
            dicionarioD.Add("Zebra", 5);
            dicionarioD.Add("Cachorro", 2);
            dicionarioD.Add("Gato", 9);
            dicionarioD.Add("Pardal", 4);
            dicionarioD.Add("C#", 100);

            //Verifica se gato existe no dicionario
            if (dicionarioD.ContainsKey("Gato"))
            {
                Console.WriteLine("Existe um value Gato nesse dicionario.");
            }

            int v;
            if(dicionarioD.TryGetValue("C#", out v))
            {
                Console.WriteLine(v);
            }
            
            //Imprime o SOrtedDictionary em ordem alfabética
            foreach (KeyValuePair<string, int> par in dicionarioD)
            {
                Console.WriteLine(par.Key + " " + par.Value);
            }
        }

        static void Main(string[] args)
        {
            //Sintaxe de instanciação e adicionando elementos no dicionarioA.
            IDictionary<int, string> dicionarioA = new Dictionary<int, string>();
            dicionarioA.Add(1, "Maria");
            dicionarioA.Add(2, "Paulo");
            dicionarioA.Add(3, "Vinícius Daniel");

            //Outra forma de instanciação e adicionar elementos ao dicionario.
            IDictionary<int, string> dicionarioB = new Dictionary<int, string>()
            {
                { 1, "Jonas" },
                { 2, "Carla" },
                { 3, "Augusto" }
            };

            Dictionary<int, string> dicionarioC = new Dictionary<int, string>()
            {
                {1, "Banana" },
                {2, "Laranja" },
                {3, "Manga" },
                {4, "Abacate" },
                {5, "Maça" }
            };

            //Percorre todo o dicionarioC e mostra todos os itens contidos.
            foreach (KeyValuePair<int, string> item in dicionarioC)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(dicionarioC[2]); //Retorna Laranja
            Console.WriteLine(dicionarioC[4]); //Retorna Abacate

            string resultado;
            if(dicionarioC.TryGetValue(4, out resultado)) //Tenta pegar o valor que esta na key 4
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Não foi possível achar a chave especificada.");
            }

            Console.WriteLine(dicionarioC.ContainsKey(1)); //Retorna true
            Console.WriteLine(dicionarioC.ContainsKey(6)); //Retorna false

            Console.WriteLine(dicionarioC.ContainsValue("Manga")); //Retorna true
            Console.WriteLine(dicionarioC.ContainsValue("Uva")); //Retorna false

            dicionarioC.Remove(2); //Remove o elemento 2 do dicionario.

            Console.WriteLine("\nDicionario Atualizado:");
            foreach (KeyValuePair<int, string> item in dicionarioC)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            string fruta;
            dicionarioC.Remove(3, out fruta); //Remove o elemento 3 e retorna o value do elemento removido.
                Console.WriteLine(fruta + " removida com sucesso!");

            Console.WriteLine("\nDicionario Atualizado:");
            foreach (KeyValuePair<int, string> item in dicionarioC)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}