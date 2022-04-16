using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IumeLibrary.Nivel
{
    public static class Alto
    {
		public static byte Local()
		{
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 19)
			{
				equipo1 += 0;
			}
			else if (dado1 < 44)
			{
				equipo1 += 1;
			}
			else if (dado1 < 69)
			{
				equipo1 += 2;
			}
			else if (dado1 < 85)
			{
				equipo1 += 3;
			}
			else if (dado1 < 93)
			{
				equipo1 += 4;
			}
			else if (dado1 < 97)
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

			if (dado1 < 33)
			{
				equipo1 += 0;
			}
			else if (dado1 < 69)
			{
				equipo1 += 1;
			}
			else if (dado1 < 88)
			{
				equipo1 += 2;
			}
			else if (dado1 < 95)
			{
				equipo1 += 3;
			}
			else if (dado1 < 99)
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
