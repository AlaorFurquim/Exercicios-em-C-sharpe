using System;
using System.Collections.Generic;
using System.Text;

namespace Cotacao_Dolar
{
    class Conversor
    {
        public static double iof = 6.0;

        public static double DolarParaReal( double quantidade,double cotacao)
        {
            double total = quantidade * cotacao;
            return total + total * iof / 100;
        }

        
    }
}
