using IumeLibrary.Nivel;

namespace IumeWindows
{
    public partial class IumeHome : Form
    {
        public IumeHome()
        {
            InitializeComponent();
        }

        private void btnReportBug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si encontraste alg�n bug, por favor avisa a @Frank9412_co en twitter. Env�a pantallazo con lo que pas� y se intentar� arreglar lo antes posible.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCampoNeutral_Click(object sender, EventArgs e)
        {
            bool isNeeded = true;
            do
            {
                string resultado = $"El resultado es: {Neutral.Resultado()}.";
                var respuesta = MessageBox.Show($"{resultado}\n�Quieres simular otro partido con este sistema?", "Resultado",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta == DialogResult.No)
                {
                    isNeeded = false;
                }
            } while(isNeeded);
        }
    }
}