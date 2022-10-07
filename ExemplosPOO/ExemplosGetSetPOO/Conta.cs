namespace ExemplosGetSetPOO
{
    public class Conta
    {
        public Cliente cliente;
        private double saldo;
        private string tipo;

        public Conta(Cliente cliente, double saldo, string tipo)
        {
            this.cliente = cliente;
            this.saldo = saldo;
            this.tipo = tipo;
        }
        public void Creditar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Creditado: " + valor);
        }

        public void Debitar(double valor)
        {
            saldo -= valor;
            Console.WriteLine("Debitado: " + valor);
        }
        public double GetSaldo()
        {
            return saldo;
        }
    }  
}
