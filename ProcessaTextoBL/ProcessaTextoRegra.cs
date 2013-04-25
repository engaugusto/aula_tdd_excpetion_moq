using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessaTextoBL
{
    public class ProcessaTextoRegra
    {
        public List<int> ConverteEntradaEmDias(string entradaUsu)
        {
            List<int> retDias = new List<int>();
            for (int i = 0; i < entradaUsu.Length; i++)
            {
                if (entradaUsu[i] == 'B')
                    retDias.Add(i + 1);
            }

            return retDias;
        }
    }
}
