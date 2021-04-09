using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Conta_Banco
{
    class ContaBancaria
    {
        public int Numero;
        public string Titular;
        public double Saldo;


        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular,double saldo) : this(numero, titular) 
        {
            Saldo = saldo;

        }
        
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return "Conta: "
                + Numero
                + " Titular: "
                + Titular
                + " Saldo: $ "
                + Saldo.ToString("f1", CultureInfo.InvariantCulture);
        }

    }
    
}
