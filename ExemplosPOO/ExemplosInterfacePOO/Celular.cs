namespace ExemplosInterfacePOO
{
    internal class Celular : IEletronico
    {
        private bool _ligado;
        public bool Ligado { get => _ligado; set => _ligado = value; }

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando o celular.");
        }

        public void Ligar()
        {
            _ligado = true;
            Console.WriteLine("Ligando o celular.");
        }
    }
}
