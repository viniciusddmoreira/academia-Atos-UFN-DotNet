namespace ExemplosBasicosPOO
{
    internal class Lampada
    {
        private bool ligada;
        public double potencia;

        public void Ligar()
        {
            ligada = true;
            Console.WriteLine("Ligando lâmpada!");
        }

        public void Desligar()
        {
            ligada = false;
            Console.WriteLine("Desligando lâmpada!");
        }

        public bool EstaLigada()
        {
            return ligada;
        }
    }
}