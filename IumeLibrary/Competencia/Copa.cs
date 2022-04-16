using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IumeLibrary.Competencia
{
    public static class Copa
    {
        public static byte Primera()
        {
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 16)
			{
				equipo1 += 0;
			}
			else if (dado1 < 40)
			{
				equipo1 += 1;
			}
			else if (dado1 < 60)
			{
				equipo1 += 2;
			}
			else if (dado1 < 80)
			{
				equipo1 += 3;
			}
			else if (dado1 < 91)
			{
				equipo1 += 4;
			}
			else if (dado1 < 95)
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

		public static byte Segunda()
		{
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 30)
			{
				equipo1 += 0;
			}
			else if (dado1 < 65)
			{
				equipo1 += 1;
			}
			else if (dado1 < 95)
			{
				equipo1 += 2;
			}
			else if (dado1 < 100)
			{
				equipo1 += 3;
			}
			else
			{
				equipo1 += 4;
			}
			return equipo1;
		}

		public static byte Tercera()
		{
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 36)
			{
				equipo1 += 0;
			}
			else if (dado1 < 90)
			{
				equipo1 += 1;
			}
			else if (dado1 < 100)
			{
				equipo1 += 2;
			}
			else
			{
				equipo1 += 3;
			}
			return equipo1;
		}

		public static byte Cuarta()
		{
			Random random = new Random();
			byte equipo1 = 0;
			byte dado1 = (byte)(random.Next(100) + 1);

			if (dado1 < 46)
			{
				equipo1 += 0;
			}
			else if (dado1 < 95)
			{
				equipo1 += 1;
			}
			else if (dado1 < 100)
			{
				equipo1 += 2;
			}
			else
			{
				equipo1 += 3;
			}
			return equipo1;
		}
	}
}
