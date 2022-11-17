namespace ExemploBasicoWinForms
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Pessoa()
        {
        }

        public static bool JaCadastrado(string nome, List<Pessoa> lista)
        {
            foreach (Pessoa item in lista)
            {
                if (nome.Equals(item.Nome))
                    return true;
            }
            return false;
        }
    }
}
