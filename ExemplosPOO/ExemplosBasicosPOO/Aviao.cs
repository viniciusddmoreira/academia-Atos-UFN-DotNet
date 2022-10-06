namespace ExemplosBasicosPOO
{
    internal class Aviao
    {
        public string modelo;
        private double _velocidade;
        private double _altitude;
        public string marca;

        public void Acelerar(double velocidade)
        {
            _velocidade = _velocidade + velocidade;           
        }

        public void Reduzir(double velocidade)
        {
            _velocidade = _velocidade - velocidade;
        }

        public void Subir(double altitude)
        {
            _altitude = _altitude + altitude;
        }

        public void Descer(double altitude)
        {
            _altitude = _altitude - altitude;
        }

        public string RetornarDados()
        {
            return "\nModelo: " + modelo + "\nMarca: " + marca;
        }

        public double VerificarVelocidade()
        {
            return _velocidade;
        }

        public double VerificarAltitude()
        {
            return _altitude;
        }

    }
}