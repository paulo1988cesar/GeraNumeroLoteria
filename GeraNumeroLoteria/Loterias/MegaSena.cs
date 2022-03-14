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
                int qtdNumeros = 0;
                int.TryParse(Console.ReadLine(), out qtdNumeros);

                if (qtdNumeros == 0)
                    Console.WriteLine("Informe um número válido, informe uma quantidade mínima de 6 números.");

                var numeros = new List<short>();

                if (qtdNumeros < 6)
                    Console.WriteLine("Quantidade de números inválida, informe uma quantidade mínima de 6 números.");

                for (int i = 0; i < qtdNumeros; i++)
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
    }
}
