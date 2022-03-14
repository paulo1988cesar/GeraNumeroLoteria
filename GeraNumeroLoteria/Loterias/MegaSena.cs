using GeraNumeroLoteria.AbstractLoteria;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeraNumeroLoteria.Loterias
{
    public class MegaSena : BaseLoteria
    {
        public override void GeraNumeros()
        {
            try
            {
                Console.WriteLine("Loteria escolhia: Mega Sena");
                Console.WriteLine("Digite a quantidade de números:");

                if (!ValidaEntradas())
                    return;

                numeros = new List<short>();

                for (int i = 0; i < QtdNumeros; i++)
                    numeros.Add(GeraNumeroDelimitado(1, 60, numeros));

                Console.WriteLine($"Os números gerados foram: {string.Join('-', numeros.OrderBy(c => c).ToList())}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override short GeraNumeroDelimitado(int min, int max, List<short> numerosGerados)
        {
            short numero = (short)new Random().Next(min, max);

            if (numerosGerados.Contains(numero))
                return GeraNumeroDelimitado(min, max, numerosGerados);

            return numero;
        }

        public override bool ValidaEntradas()
        {
            int qtdNumeros;
            int.TryParse(Console.ReadLine(), out qtdNumeros);

            QtdNumeros = qtdNumeros;

            if (QtdNumeros == 0)
            {
                Console.WriteLine("Informe um número válido, informe uma quantidade mínima de 6 números.");
                return false;
            }
            var numeros = new List<short>();

            if (QtdNumeros < 6)
            {
                Console.WriteLine("Quantidade de números inválida, informe uma quantidade mínima de 6 números.");
                return false;
            }

            return true;
        }
    }
}
