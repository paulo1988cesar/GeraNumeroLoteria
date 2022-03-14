using GeraNumeroLoteria.AbstractLoteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeraNumeroLoteria.Enumeradores.Enumeradores;

namespace GeraNumeroLoteria.Loterias
{
    public class LoteriaFactory : LoteriaFactoryMethod
    {
        public override BaseLoteria CriaLoteria(short tipo)
        {
            switch (tipo)
            {
                case (short)TipoLoteria.MegaSena:
                    return new MegaSena();
                case (short)TipoLoteria.LotoFacil:
                    return new LotoFacil();
                default:
                    break;
            }

            return null;
        }
    }
}
