using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IumeLibrary.Nivel;

namespace IumeWindows
{
    public partial class IumeStandardMatchForm : Form
    {
        public IumeStandardMatchForm()
        {
            InitializeComponent();
        }

        private void btnStdResult_Click(object sender, EventArgs e)
        {
            var cmbResultLocal= cmbLocal.SelectedIndex;
            var cmbResultVisitante = cmbVisitante.SelectedIndex;

            bool haceFalta = cmbResultLocal == -1 || cmbResultVisitante == -1;

            if (haceFalta)
                MessageBox.Show("No están completos los datos de los rivales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                byte gLocal = 0, gVisitante = 0;
                switch (cmbResultLocal) {
                    case 0:
                        gLocal = IumeLibrary.Nivel.Top.Local();
                        break;
                    case 1:
                        gLocal = Alto.Local();
                        break;
                    case 2:
                        gLocal = Medio.Local();
                        break;
                    case 3:
                        gLocal = Bajo.Local();
                        break;
                }

                switch (cmbResultVisitante)
                {
                    case 0:
                        gVisitante = IumeLibrary.Nivel.Top.Visitante();
                        break;
                    case 1:
                        gVisitante = Alto.Visitante();
                        break;
                    case 2:
                        gVisitante = Medio.Visitante();
                        break;
                    case 3:
                        gVisitante = Bajo.Visitante();
                        break;
                }

                string resultado = $"El resultado es: {gLocal}-{gVisitante}.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var respuesta = MessageBox.Show($"{resultado}\n¿Quieres simular otro partido con este sistema?", "Resultado",
                //            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}
