using GeraNumeroLoteria.Loterias;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeraNumeroLoteria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Aplicativo Console - Para Geração de números da Loteria");

                bool showMenu = true;

                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        private static bool MainMenu()
        {
            try
            {
                GeraMensagensTela();

                short selecao = Convert.ToSByte(Console.ReadLine());

                if (selecao.Equals(7))
                    return false;
                else
                {
                    if (selecao < 0 || selecao > 7)
                    {
                        Console.WriteLine("Informe um número de loteria válido para geração dos números");
                        return true;
                    }
                }

                LoteriaFactory factory = new LoteriaFactory();
                var loteria = factory.CriaLoteria(selecao);
                loteria.GeraNumeros();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private static void GeraMensagensTela()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(String.Empty);

            sb.AppendLine("1 - Mega Sena");
            sb.AppendLine("2 - LotoFácil");
            sb.AppendLine("3 - Quina");
            sb.AppendLine("4 - Lotomania");
            sb.AppendLine("5 - Timemania");
            sb.AppendLine("6 - Dia da Sorte");
            sb.AppendLine("7 - Sair");

            Console.WriteLine(sb.ToString());
        }
    }
}
