using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Salario_Imposto
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }
        public override string ToString()
        {
            return Nome
                + ", R$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
