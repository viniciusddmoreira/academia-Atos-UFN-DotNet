namespace ExemplosGetSetPOO
{
    public class Temperatura
    {
        private double celsius = 0;

        public double GetCelsius()
        {
            return ((celsius * 9) / 5) + 32; //converte para fahrenheit
        }

        public void SetCelsius(double fahrenheit) 
        {
            celsius = ((fahrenheit - 32) * 5) / 9; //converte para celsius
        }
    }
}
