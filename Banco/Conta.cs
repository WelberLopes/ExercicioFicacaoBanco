using System.Globalization;

namespace Banco {
    internal class Conta {

        private string _nomeTitular;
        public string _nConta { get; private set; }
        public double _saldo { get; private set; }

        public Conta() { }
        public Conta(string Nome,string Conta, double Deposito) {

            _nomeTitular = Nome;
            _nConta = Conta;    
            _saldo = Deposito;
        }

        private void SetNumeroConta(string nConta) {
            _nConta = nConta;
        }

        public void SetNomeTitular(string nomeTitular) {
            _nomeTitular = nomeTitular;
        }

        public static void Deposito(double Montante, Conta c1) {
            c1._saldo += Montante;
        }
        public static void Saque(double Montante, Conta c1) {
            c1._saldo = c1._saldo - Montante - 5.00;
        }

        public override string ToString() {
            return "Dados da conta:\n" +
                   "Conta: " + _nConta + "\nTitular: " + _nomeTitular + "\nSaldo: R$" + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
