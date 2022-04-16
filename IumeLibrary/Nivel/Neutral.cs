using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IumeLibrary.Nivel
{
    public static class Neutral
    {
        public static string Resultado()
        {
            Random random = new Random();
            byte equipo1 = 0;
            byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 == 1)
			{
				equipo1 += 1;
			}
			else if (dado1 < 27)
			{
				equipo1 += 0;
			}
			else if (dado1 < 58)
			{
				equipo1 += 1;
			}
			else if (dado1 < 81)
			{
				equipo1 += 2;
			}
			else if (dado1 < 92)
			{
				equipo1 += 3;
			}
			else if (dado1 < 98)
			{
				equipo1 += 4;
			}
			else if (dado1 < 100)
            {
				byte bonus = (byte)(random.Next(4) + 1);
				equipo1 += (byte)(4 + bonus);
            }
			else
			{
				byte bonus = (byte)(random.Next(4) + 1);
				equipo1 += (byte)(5 + bonus);
			}

			byte equipo2 = 0;
            byte dado2 = (byte)(random.Next(100) + 1);

			if (dado2 == 1)
			{
				equipo2 += 1;
			}
			else if (dado2 < 27)
			{
				equipo2 += 0;
			}
			else if (dado2 < 58)
			{
				equipo2 += 1;
			}
			else if (dado2 < 81)
			{
				equipo2 += 2;
			}
			else if (dado2 < 92)
			{
				equipo2 += 3;
			}
			else if (dado2 < 98)
			{
				equipo2 += 4;
			}
			else if (dado2 < 100)
			{
				byte bonus = (byte)(random.Next(4) + 1);
				equipo2 += (byte)(4 + bonus);
			}
			else
			{
				byte bonus = (byte)(random.Next(4) + 1);
				equipo2 += (byte)(5 + bonus);
			}
			return $"{equipo1}-{equipo2}";
		}
    }
}
