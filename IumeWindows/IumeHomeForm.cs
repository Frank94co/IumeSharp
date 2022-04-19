using IumeLibrary.Competencia;
using IumeLibrary.Nivel;

namespace IumeWindows
{
    public partial class IumeHomeForm : Form
    {
        public IumeHomeForm()
        {
            InitializeComponent();
        }

        private void btnReportBug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si encontraste algún bug, por favor avisa a @Frank9412_co en twitter. Envía pantallazo con lo que pasó y se intentará arreglar lo antes posible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCampoNeutral_Click(object sender, EventArgs e)
        {
            bool isNeeded = true;
            do
            {
                string resultado = $"El resultado es: {Neutral.Resultado()}.";
                var respuesta = MessageBox.Show($"{resultado}\n¿Quieres simular otro partido con este sistema?", "Resultado",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta == DialogResult.No)
                {
                    isNeeded = false;
                }
            } while(isNeeded);
        }

        private void btnLocVisi_Click(object sender, EventArgs e)
        {
            IumeStandardMatchForm iumeStandardMatchForm = new IumeStandardMatchForm();
            iumeStandardMatchForm.Show();
        }

        private void btnCopa_Click(object sender, EventArgs e)
        {
            IumeCupMatchForm iumeCupMatchForm = new IumeCupMatchForm();
            iumeCupMatchForm.Show();
        }

        private void btnCopaEntera_Click(object sender, EventArgs e)
        {
            try
            {
                if(seleccionarArchivo.ShowDialog()== DialogResult.OK)
                {
                    if (seleccionarArchivo.CheckFileExists)
                    {
                        List<Equipo> equipos = new List<Equipo>();
                        using (var sr = new StreamReader(seleccionarArchivo.FileName))
                        {
                            string line;
                            while((line = sr.ReadLine()) != null)
                            {
                                string[] infoEquipos = line.Split('|');
                                Equipo equipo = new Equipo(infoEquipos[0], Convert.ToByte(infoEquipos[1]));
                                equipos.Add(equipo);
                            }
                        }
                        var respuesta = MessageBox.Show($"Se han cargado {equipos.Count} equipos, ¿deseas continuar?",
                            "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if(respuesta== DialogResult.Yes)
                        {
                            CopaEntera(equipos, 1);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopaEntera(List<Equipo> participantes, int ronda)
        {
            List<Equipo> ganadores = new List<Equipo>();
            if (participantes.Count == 1)
            {
                MessageBox.Show($"El ganador del torneo es: {participantes[0]}",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //Calcula la potencia de 2 menor a la cantidad de participantes
                int potencia = (int)Math.Floor(Math.Log2(participantes.Count));
                int exentos = (int)(participantes.Count - Math.Pow(2, potencia));
                if (exentos >= 0)
                {
                    for (int i = 1; i <= exentos; i++)
                    {
                        participantes.Add(new Equipo("Bye", categoria: 5));
                    }
                }

                short iteraciones = (short)(participantes.Count / 2);
                Random random = new Random();
                Equipo local, visitante;
                short aux;

                string resultado = "";
                for (short i = 0; i < iteraciones; i++)
                {
                    //programa los equipos exentos
                    if(participantes.Find(e => e.Nombre == "Bye") != null)
                    {
                        aux = (short)random.Next(participantes.Count - exentos);
                        int indiceBye = participantes.FindLastIndex(e => e.Nombre == "Bye");
                        if (aux % 2 == 0)
                        {
                            local = participantes[aux];
                            visitante = participantes[indiceBye];
                        }
                        else
                        {
                            visitante = participantes[aux];
                            local = participantes[indiceBye];
                        }
                    }
                    else
                    {
                        //de este bucle no se sale sino hasta que encuentre dos equipos que se llamen distinto
                        do
                        {
                            aux = (short)random.Next(participantes.Count);
                            local = participantes[aux];
                            aux = (short)random.Next(participantes.Count);
                            visitante = participantes[aux];
                        } while (local.Nombre == visitante.Nombre);
                    }
                    participantes.Remove(local);
                    participantes.Remove(visitante);
                    
                    if (local.Nombre == "Bye")
                    {
                        ganadores.Add(visitante);
                        resultado += $"{visitante.Nombre} descansa. \n";
                    }
                    else if (visitante.Nombre == "Bye")
                    {
                        ganadores.Add(local);
                        resultado += $"{local.Nombre} descansa. \n";
                    }

                    else
                    {
                        short diferencia = (short)(local.Categoria - visitante.Categoria);
                        byte rLocal, rVisitante;
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
                        resultado += $"{local} {rLocal}-{rVisitante} {visitante}. ";
                        if (rLocal > rVisitante)
                        {
                            ganadores.Add(local);
                            resultado += "\n";
                        }
                        else if (rVisitante > rLocal)
                        {
                            ganadores.Add(visitante);
                            resultado += "\n";
                        }
                        else
                        {
                            Tuple<int, int, int> tandaPenaltis = Copa.EjecutarTandaPenaltis();
                            int penalesLanzados = 0;
                            if (tandaPenaltis.Item1 > tandaPenaltis.Item2)
                            {
                                penalesLanzados = (tandaPenaltis.Item3 * 2) - 1;
                                ganadores.Add(local);
                            }
                            else
                            {
                                penalesLanzados = tandaPenaltis.Item3 * 2;
                                ganadores.Add(visitante);
                            }

                            resultado += $"Por tanda de penaltis, el resultado fue {tandaPenaltis.Item1}-{tandaPenaltis.Item2}, después de {penalesLanzados} penales lanzados \n";
                        }
                    }
                }
                var respuesta= MessageBox.Show(resultado, $"Ronda {ronda} terminada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta == DialogResult.Yes)
                {
                    ronda = ronda + 1;
                    CopaEntera(ganadores, ronda);
                }
            }
        }
    }
}