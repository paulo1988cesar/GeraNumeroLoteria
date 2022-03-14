using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraNumeroLoteria.AbstractLoteria
{
    public abstract class BaseLoteria
    {
        public abstract void GeraNumeros();
        public abstract short GeraNumeroDelimitado(int min, int max, List<short> numerosGerados);
    }
}
