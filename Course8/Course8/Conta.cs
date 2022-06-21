using System;
using System.Globalization;

namespace Course8
{
    internal class Conta
    {
        public string NumConta { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }

        public Conta()
        {
            Saldo = 0;
        }
        public Conta(string numConta, string titular) : this()
        {
            NumConta = numConta;
            _titular = titular;
        }
        public Conta(string numConta, string titular, double saldo) : this(numConta, titular)
        {
            Saldo = saldo;
        }

        public string Titular
        {
            get { return _titular; }
            set { if (value != null)
                {
                    _titular = value;
                } }
        }


        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque;
        }


        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + _titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
