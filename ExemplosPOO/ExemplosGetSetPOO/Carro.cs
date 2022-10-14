namespace ExemplosGetSetPOO
{
    public class Carro
    {
        public double VelocidadeMax { get; set; }
        //public double VelocidadeMax { get => velocidadeMax; set => velocidadeMax = value; }
        public string Modelo { get; set; }
        //public string Modelo { get => modelo; set => modelo = value; }
        private string cor;
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        private bool ligado = false;        
        
        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public string GetCor()
        {
            return cor;
        }

        public void SetCor(string cor)
        {
            this.cor = cor;
        }

        public bool GetLigado()
        {
            return ligado;
        }
    }
}
