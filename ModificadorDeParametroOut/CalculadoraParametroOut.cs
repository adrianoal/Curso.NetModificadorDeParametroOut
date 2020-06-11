using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDeParametroOut
{
    class Calculator
    {
        public static void Triple(int origin, out int result)// eu passo um parametro de (entrada), e guardo em outro parametro de (saida)
        {
            result = origin * 3;
        }

    }
}
