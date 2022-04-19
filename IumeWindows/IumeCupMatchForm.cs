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
                Tuple<int, int, int> tandaPenaltis = Copa.EjecutarTandaPenaltis();
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
    }
}
