namespace ExemplosBasicosPOO
{
    internal class ContaBancaria
    {
        public string agencia;
        public string tipo;
        private double _valor;
        public string conta;

        public ContaBancaria(string agencia, string tipo, double valor, string conta)
        {
            this.agencia = agencia;
            this.tipo = tipo;
            _valor = valor;
            this.conta = conta;
        }

        public ContaBancaria()
        {

        }

        public void Sacar(double saque)
        {
            _valor = _valor - saque;
        }

        public void Depositar(double saque)
        {
            _valor = _valor + saque;
        }

        public string ConsultarSaldo()
        {
            return "Saldo da conta: " + _valor;
        }

        public string RetornaDados()
        {
            return "\nAgencia: " + agencia + "\nTipo: " + tipo + "\nConta: " + conta;
        }
    }
}