using IumeLibrary.Competencia;
using IumeLibrary.Nivel;
using System;
using System.Collections.Generic;

namespace IumeSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            string respuesta;
            do
            {
                Console.WriteLine("Bienvenido a IumeSharp, versión 0.0.1");
                Console.WriteLine("¿Qué quieres simular? (introduce el número)");
                Console.WriteLine("0) Nada");
                Console.WriteLine("1) Partido en campo neutral");
                Console.WriteLine("2) Partido con local y visitante");
                Console.WriteLine("3) Partido de Copa (sistema rosianio)");
                Console.WriteLine("4) Copa entera (sistema rosianio)");
                Console.WriteLine("5) Bug");
                Console.WriteLine("6) insultar a Frank");
                respuesta = Console.ReadLine();

                switch (respuesta)
                {
                    case "0":
                        Console.WriteLine("Espero te haya servido el programa");
                        break;
                    case "1":
                        char respuesta2;
                        do
                        {
                            Console.WriteLine($"El resultado es {Neutral.Resultado()}");
                            Console.WriteLine("¿Quieres simular otro partido con este sistema?");
                            respuesta2 = Console.ReadLine().ToUpper()[0];
                        } while (respuesta2 == 'S');
                        Neutral.Resultado();
                        break;
                    case "2":
                        byte nLocal, nVisitante, rLocal, rVisitante;
                        do
                        {
                            rLocal = 0;
                            Console.WriteLine("¿Qué nivel tiene el equipo local?");
                            Console.WriteLine("1- Top");
                            Console.WriteLine("2- Alto");
                            Console.WriteLine("3- Medio");
                            Console.WriteLine("4- Bajo");
                            Byte.TryParse(Console.ReadLine(), out nLocal);
                            switch (nLocal)
                            {
                                case 1:
                                    rLocal += Top.Local();
                                    break;
                                case 2:
                                    rLocal += Alto.Local();
                                    break;
                                case 3:
                                    rLocal += Medio.Local();
                                    break;
                                case 4:
                                    rLocal += Bajo.Local();
                                    break;
                                default:
                                    Console.WriteLine("No es una opción válida");
                                    break;
                            }
                        } while (nLocal > 4 || nLocal < 0);
                        do
                        {
                            rVisitante = 0;
                            Console.WriteLine("¿Qué nivel tiene el equipo visitante?");
                            Console.WriteLine("1- Top");
                            Console.WriteLine("2- Alto");
                            Console.WriteLine("3- Medio");
                            Console.WriteLine("4- Bajo");
                            Byte.TryParse(Console.ReadLine(), out nVisitante);
                            switch (nVisitante)
                            {
                                case 1:
                                    rVisitante += Top.Local();
                                    break;
                                case 2:
                                    rVisitante += Alto.Local();
                                    break;
                                case 3:
                                    rVisitante += Medio.Local();
                                    break;
                                case 4:
                                    rVisitante += Bajo.Local();
                                    break;
                                default:
                                    Console.WriteLine("No es una opción válida");
                                    break;
                            }
                        } while (nLocal > 4 || nLocal < 0);
                        Console.WriteLine($"El resultado es {rLocal}-{rVisitante}");
                        break;
                    case "3":
                        byte nprimero;
                        byte rprimero;
                        byte rsegundo;
                        char respuestaCopa;
                        do
                        {
                            do
                            {
                                rprimero = 0;
                                Console.WriteLine("¿En qué categoría está el primer equipo?\n\t"

                                    + "1- Primera\n\t"
                                    + "2- Segunda\n\t"
                                    + "3- Tercera\n\t"
                                    + "4- Cuarta\n\t");

                                Byte.TryParse(Console.ReadLine(), out nprimero);

                                switch (nprimero)
                                {
                                    case 1:
                                        rprimero += Copa.Primera();
                                        break;
                                    case 2:
                                        rprimero += Copa.Segunda();
                                        break;
                                    case 3:
                                        rprimero += Copa.Tercera();
                                        break;
                                    case 4:
                                        rprimero += Copa.Cuarta();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción válida");
                                        break;
                                }
                            } while (nprimero > 4 || nprimero < 0);
                            byte nsegundo;
                            do
                            {
                                rsegundo = 0;
                                Console.WriteLine("¿En qué categoría está el segundo equipo?\n\t"

                                    + "1- Primera\n\t"
                                    + "2- Segunda\n\t"
                                    + "3- Tercera\n\t"
                                    + "4- Cuarta\n\t");
                                Byte.TryParse(Console.ReadLine(), out nsegundo);
                                
                                switch (nsegundo)
                                {
                                    case 1:
                                        rsegundo += Copa.Primera();
                                        break;
                                    case 2:
                                        rsegundo += Copa.Segunda();
                                        break;
                                    case 3:
                                        rsegundo += Copa.Tercera();
                                        break;
                                    case 4:
                                        rsegundo += Copa.Cuarta();
                                        break;
                                    default:
                                        Console.WriteLine("Esa no es una opción válida");
                                        break;
                                }
                            } while (nsegundo > 4 || nsegundo < 0);
                            Console.WriteLine("El resultado es " + rprimero + "-" + rsegundo);
                            Console.WriteLine("¿Quieres simular otro partido con este sistema? (S/N)");
                            respuestaCopa = Console.ReadLine().ToUpper()[0];
                        } while (respuestaCopa == 'S');
                        break;
                    case "4":
                        List<Equipo> participantes = new List<Equipo>();
                        char otro;
                        do
                        {
                            Console.WriteLine("¿Cuántos equipos participarán?");
                            short cantidad = Convert.ToInt16(Console.ReadLine());
                            for (short i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine($"Introduce el nombre del equipo {i + 1}");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("¿En qué categoría está?");
                                byte categoria = Convert.ToByte(Console.ReadLine());
                                participantes.Add(new Equipo(nombre, categoria));
                            }
                            CopaEntera(participantes);
                            Console.WriteLine("¿Quieres simular otro torneo?");
                            otro = Console.ReadLine().ToUpper()[0];
                        } while (otro == 'S');
                        break;
                    case "5":
                        Console.WriteLine("Si encontraste algún bug, por favor avisa a @Frank9412_co en twitter. Envía pantallazo con lo que pasó y se intentará arreglar lo antes posible.");
                        break;
                    case "6":
                        Console.WriteLine("Tus muertos pisaos");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtalo de nuevo");
                        break;
                }
            } while (respuesta != "0");

            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();
            
        }

        public static void CopaEntera(List<Equipo> participantes)
        {
            List<Equipo> ganadores = new List<Equipo>();
            _ = new Competencia((short)participantes.Count, participantes);
            if (participantes.Count == 1)
            {
                Console.WriteLine($"El ganador del torneo es: {participantes[0]}");
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

                for (short i = 0; i < iteraciones; i++)
                {
                    //programa los equipos exentos
                    if (participantes.Find(e => e.Nombre == "Bye") != null)
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
                        Console.WriteLine($"{visitante.Nombre} descansa");
                    }
                    else if (visitante.Nombre == "Bye")
                    {
                        ganadores.Add(local);
                        Console.WriteLine($"{local.Nombre} descansa");
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
                        var resultado = $"{local} {rLocal}-{rVisitante} {visitante}. ";
                        if (rLocal > rVisitante)
                        {
                            ganadores.Add(local);
                        }
                        else if (rVisitante > rLocal)
                        {
                            ganadores.Add(visitante);
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
                            resultado += $"Por tanda de penaltis, el resultado fue {tandaPenaltis.Item1}-{tandaPenaltis.Item2}, después de {penalesLanzados} penales lanzados.";
                        }
                        Console.WriteLine(resultado);
                    }
                }
                Console.WriteLine("-------------------------------------------------");
                CopaEntera(ganadores);
            }

        }
    }
}
