﻿using GeraNumeroLoteria.AbstractLoteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraNumeroLoteria.Loterias
{
    public class LotoFacil : BaseLoteria
    {
        public override void GeraNumeros()
        {
            throw new NotImplementedException();
        }

        public override short GeraNumeroDelimitado(int min, int max, List<short> numerosGerados)
        {
            throw new NotImplementedException();
        }
    }
}
