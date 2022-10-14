namespace ExemplosInterfacePOO
{
    internal class Televisao : IEletronico
    {
        private bool _ligado;
        public bool Ligado { get => _ligado; set => _ligado = value; }

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando a televisão.");
        }

        public void Ligar()
        {
            _ligado = true;
            Console.WriteLine("Ligando a televisão.");
        }
    }
}
