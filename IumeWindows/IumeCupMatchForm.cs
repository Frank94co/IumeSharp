using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IumeLibrary.Competencia;

namespace IumeWindows
{
    public partial class IumeCupMatchForm : Form
    {
        public IumeCupMatchForm()
        {
            InitializeComponent();
        }

        private void btnCupResult_Click(object sender, EventArgs e)
        {
            var catLocal = spinLocal.Value;
            var catVisitante = spinVisitante.Value;

            byte rLocal = 0, rVisitante = 0;
            var diferencia = catLocal - catVisitante;

            switch (diferencia)
            {
                case -2:
                    rLocal = Copa.Primera();
                    rVisitante = Copa.Tercera();
                    break;
                case -1:
                    rLocal = Copa.Primera();
                    rVisitante = Copa.Segunda();
                    break;
                case 0:
                    rLocal = Copa.Primera();
                    rVisitante = Copa.Primera();
                    break;
                case 1:
                    rLocal = Copa.Segunda();
                    rVisitante = Copa.Primera();
                    break;
                case 2:
                    rLocal = Copa.Tercera();
                    rVisitante = Copa.Primera();
                    break;
                default:
                    if (diferencia > 0)
                    {
                        rLocal = Copa.Cuarta();
                        rVisitante = Copa.Primera();
                    }
                    else
                    {
                        rLocal = Copa.Primera();
                        rVisitante = Copa.Cuarta();
                    }
                    break;
            }
            string resultado = $"El resultado es {rLocal}-{rVisitante}. ";
            if (rLocal == rVisitante)
            {
                Tuple<int, int, int> tandaPenaltis = EjecutarTandaPenaltis();
                int penalesLanzados = 0;
                if (tandaPenaltis.Item1 > tandaPenaltis.Item2)
                {
                    penalesLanzados = (tandaPenaltis.Item3 * 2) - 1;
                }
                else
                {
                    penalesLanzados = tandaPenaltis.Item3 * 2;
                }
                
                resultado += $"Por tanda de penaltis, el resultado fue {tandaPenaltis.Item1}-{tandaPenaltis.Item2}, después de {penalesLanzados} penales lanzados";
            }

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private Tuple<int, int, int> EjecutarTandaPenaltis()
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
