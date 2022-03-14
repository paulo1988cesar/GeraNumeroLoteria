using GeraNumeroLoteria.AbstractLoteria;
using static GeraNumeroLoteria.Enumeradores.Enumeradores;

namespace GeraNumeroLoteria.Loterias
{
    public class LoteriaFactory : LoteriaFactoryMethod
    {
        public override BaseLoteria CriaLoteria(short tipo)
        {
            switch (tipo)
            {
                case (short)TipoLoteria.DiaSorte:
                    return new DiaSorte();
                case (short)TipoLoteria.LotoFacil:
                    return new LotoFacil();
                case (short)TipoLoteria.Lotomania:
                    return new Lotomania();
                case (short)TipoLoteria.MegaSena:
                    return new MegaSena();
                case (short)TipoLoteria.Quina:
                    return new Quina();
                case (short)TipoLoteria.Timemania:
                    return new Timemania();
                default:
                    break;
            }

            return null;
        }
    }
}
