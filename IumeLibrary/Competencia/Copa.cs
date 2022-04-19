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

		public static Tuple<int, int, int> EjecutarTandaPenaltis()
		{
			int pLocal = 0, pVisitante = 0, diferenciaInt = 0, iaux = 0;
			for (int i = 1; i <= 5; i++)
			{
				iaux = i;
				Random random = new Random();
				int dadoLocal = random.Next(1000) + 1;
				int dadoVisitante = random.Next(1000) + 1;
				switch (i)
				{
					case 1:
						if (dadoLocal >= 206)
							pLocal++;
						if (dadoVisitante >= 206)
							pVisitante++;
						break;
					case 2:
						if (dadoLocal >= 206)
							pLocal++;
						if (dadoVisitante >= 206)
							pVisitante++;
						break;
					case 3:
						if (dadoLocal >= 274)
							pLocal++;
						if (dadoVisitante >= 274)
							pVisitante++;
						break;
					case 4:
						if (dadoLocal >= 236)
							pLocal++;
						if (dadoVisitante >= 236)
							pVisitante++;
						break;
					case 5:
						if (dadoLocal >= 160)
							pLocal++;
						if (dadoVisitante >= 160)
							pVisitante++;
						break;
				}
				diferenciaInt = Math.Abs(pLocal - pVisitante);
				if (diferenciaInt >= 3 && i >= 3)
					break;
				if (diferenciaInt >= 2 && i >= 4)
					break;
			}
			if (diferenciaInt > 0)
			{
				return new Tuple<int, int, int>(pLocal, pVisitante, iaux);
			}
			else
			{
				int penalLanzado = 6;
				while (diferenciaInt == 0)
				{
					Random random = new Random();
					int dadoLocal = random.Next(1000) + 1;
					int dadoVisitante = random.Next(1000) + 1;
					if (dadoLocal >= 327)
						pLocal++;
					if (dadoVisitante >= 327)
						pVisitante++;
					diferenciaInt = Math.Abs(pLocal - pVisitante);
					if (diferenciaInt > 0)
						break;
					else
						penalLanzado++;
				}
				return new Tuple<int, int, int>(pLocal, pVisitante, penalLanzado);
			}
		}
	}
}
