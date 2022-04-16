using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IumeLibrary.Nivel
{
    public static class Bajo
    {
		public static byte Local()
		{
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 21)
			{
				equipo1 += 0;
			}
			else if (dado1 < 48)
			{
				equipo1 += 1;
			}
			else if (dado1 < 72)
			{
				equipo1 += 2;
			}
			else if (dado1 < 88)
			{
				equipo1 += 3;
			}
			else if (dado1 < 96)
			{
				equipo1 += 4;
			}
			else if (dado1 < 99)
			{
				byte bonus = (byte)(random.Next(4) + 1);
				equipo1 += (byte)(4 + bonus);
			}
			else
			{
				byte bonus = (byte)(random.Next(4) + 1);
				equipo1 += (byte)(5 + bonus);
			}
			return equipo1;
		}

		public static byte Visitante()
		{
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 37)
			{
				equipo1 += 0;
			}
			else if (dado1 < 71)
			{
				equipo1 += 1;
			}
			else if (dado1 < 91)
			{
				equipo1 += 2;
			}
			else if (dado1 < 97)
			{
				equipo1 += 3;
			}
			else if (dado1 < 100)
			{
				equipo1 += 4;
			}
			else
			{
				byte bonus = (byte)(random.Next(4) + 1);
				equipo1 += (byte)(4 + bonus);
			}
			return equipo1;
		}
	}
}
