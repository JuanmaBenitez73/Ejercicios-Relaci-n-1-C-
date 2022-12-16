namespace Ejercicio24
{
    internal class Program
    {
        enum Rep { Inactivo, Reproduciendo, Pausado, Parado, Cerrado }
        static Rep rep = Rep.Inactivo;
        static void Main()
        {
            do
            {
                Console.WriteLine("Escribe p, s o q");
                string action = Convert.ToString(Console.ReadLine());
                action = action.ToLower();
                Console.Clear();
                try
                {
                    if (action == "p" || action == "s" || action == "q")
                    {
                        if (rep == Rep.Inactivo)
                        {
                            try
                            {
                                if (action == "p")
                                {
                                    rep = Rep.Reproduciendo;
                                    Console.WriteLine("El reproductor ahora está reproduciendo");
                                    Console.WriteLine("");
                                    Console.WriteLine("Ahora puedes introducir:");
                                    Console.WriteLine("p: Pausar Reproductor");
                                    Console.WriteLine("s: Parar Reproductor");
                                    Console.WriteLine("q: Cerrar Reproductor");
                                    Console.WriteLine("");
                                }
                                else if (action == "q")
                                {
                                    rep = Rep.Cerrado;
                                    Console.WriteLine("El reproductor ahora está cerrado");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Mientras esté inactivo solo puedes introducir p o q");
                                Console.WriteLine("");
                            }
                        }
                        else if (rep == Rep.Reproduciendo)
                        {
                            if (action == "p")
                            {
                                rep = Rep.Pausado;
                                Console.WriteLine("El reproductor ahora está pausado");
                                Console.WriteLine("");
                                Console.WriteLine("Ahora puedes introducir:");
                                Console.WriteLine("p: Reproducir Reproductor");
                                Console.WriteLine("s: Parar Reproductor");
                                Console.WriteLine("q: Cerrar Reproductor");
                                Console.WriteLine("");
                            }
                            else if (action == "q")
                            {
                                rep = Rep.Cerrado;
                                Console.WriteLine("El reproductor ahora está cerrado");
                                Console.WriteLine("");
                            }
                            else
                            {
                                rep = Rep.Parado;
                                Console.WriteLine("El reproductor ahora está parado");
                                Console.WriteLine("");
                                Console.WriteLine("Ahora puedes introducir:");
                                Console.WriteLine("q: Cerrar Reproductor");
                                Console.WriteLine("");
                            }
                        }
                        else if (rep == Rep.Pausado)
                        {
                            if (action == "p")
                            {
                                rep = Rep.Reproduciendo;
                                Console.WriteLine("El reproductor ahora está reproduciendo");
                                Console.WriteLine("");
                                Console.WriteLine("Ahora puedes introducir:");
                                Console.WriteLine("p: Pausar Reproductor");
                                Console.WriteLine("s: Parar Reproductor");
                                Console.WriteLine("q: Cerrar Reproductor");
                                Console.WriteLine("");
                            }
                            else if (action == "q")
                            {
                                rep = Rep.Cerrado;
                                Console.WriteLine("El reproductor ahora está cerrado");
                                Console.WriteLine("");
                            }
                            else
                            {
                                rep = Rep.Parado;
                                Console.WriteLine("El reproductor ahora está parado");
                                Console.WriteLine("");
                                Console.WriteLine("Ahora puedes introducir:");
                                Console.WriteLine("q: Cerrar Reproductor");
                                Console.WriteLine("");
                            }
                        }
                        else if (rep == Rep.Parado)
                        {
                            try
                            {
                                if (action != "q")
                                {
                                    Console.WriteLine("Una vez el reproductor está parado solo puede cerrarse introduciendo q");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {
                                rep = Rep.Cerrado;
                                Console.WriteLine("El reproductor ahora está cerrado");
                                Console.WriteLine("");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Debes introducir obligatoriamente una letra entre la 'p', la 's' o la 'q'");
                    Console.WriteLine("");
                }
            } while (rep != Rep.Cerrado);
        }
    }
}