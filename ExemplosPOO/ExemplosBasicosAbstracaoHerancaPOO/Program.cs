namespace ExemplosBasicosAbstracaoHerancaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal leaoA = new Leao("Leao A", "Macho", "Leão-Branco");
            Console.WriteLine(leaoA.ExibirDados()); 
            leaoA.EmitirSom();
            leaoA.Caminhar();
            leaoA.Dormir();

            Animal cachorroA = new Cachorro("Cachorro A", "Femea", "Chow Chow");
            Console.WriteLine("\n" + cachorroA.ExibirDados());
            cachorroA.EmitirSom();
            cachorroA.Caminhar();
            cachorroA.Dormir();

            Animal gatoA = new Gato("Gato A", "Femea", "Persa");
            Console.WriteLine("\n" + gatoA.ExibirDados());
            gatoA.EmitirSom();
            gatoA.Caminhar();
            gatoA.Dormir();

            Animal loboA = new Lobo("Lobo A", "Macho", "Lobo Vermelho");
            Console.WriteLine("\n" + loboA.ExibirDados());
            loboA.EmitirSom();
            loboA.Caminhar();
            loboA.Dormir();

            Animal tigreA = new Tigre("Tigre A", "Femea", "Tigre Siberiano");
            Console.WriteLine("\n" + tigreA.ExibirDados());
            tigreA.EmitirSom();
            tigreA.Caminhar();
            tigreA.Dormir();
        }
    }
}