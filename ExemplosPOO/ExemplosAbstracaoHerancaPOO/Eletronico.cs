namespace ExemplosAbstracaoHerancaPOO
{
    abstract class Eletronico
    {
        public int Volts { get; set; }
        public int Potencia { get; set; }        
        private  bool _ligado;
        public bool Ligado { get => _ligado; set => _ligado = value; }

        public abstract void Ligar();

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando o equipamento.");
        }

        //public bool VerificaLigado()
        //{
        //    return Ligado;
        //}
    }
}
