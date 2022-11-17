namespace ExemploBasicoLabelTextButton
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Jogador()
        {      
        }

        public Jogador(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public static bool JaCadastrado(string nome, List<Jogador> lista)
        {
            foreach (Jogador item in lista)
            {
                if (nome.Equals(item.Nome))
                    return true;
            }
            return false;
        }

        public static void OrdenarListaPorNome(List<Jogador> lista)
        {
            lista.Sort(delegate (Jogador pessoaA, Jogador pessoaB)
            {
                return pessoaA.Nome.CompareTo(pessoaB.Nome);
            });
        }
    }
}

