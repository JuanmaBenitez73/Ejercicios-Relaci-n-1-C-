namespace Ejercicio22
{
    class Program
    {
        enum Lamp { OFF, ON }
        static Lamp lamp = Lamp.OFF;

        static void Main()
        {
            do
            {
                Console.WriteLine("Escribe ON u OFF para encender o apagar la lámpara");
                string state = Convert.ToString(Console.ReadLine());
                state = state.ToUpper();
                if (state == "ON" || state == "OFF")
                {
                    if (lamp == Lamp.OFF)
                    {
                        if (state == "ON")
                        {
                            lamp = Lamp.ON;
                            Console.WriteLine($"El estado de la lámpara ahora es: {state}");
                            Console.WriteLine("");
                        }
                        else if (state == "OFF")
                        {
                            Console.WriteLine($"No se puede introducir el estado OFF porque la lámpara ya está apagada");
                            Console.WriteLine("");
                        }
                    }
                    else if (lamp == Lamp.ON)
                    {
                        if (state == "OFF")
                        {
                            lamp = Lamp.OFF;
                            Console.WriteLine($"El estado de la lámpara ahora es: {state}");
                            Console.WriteLine("");
                        }
                        else if (state == "ON")
                        {
                            Console.WriteLine($"No se puede introducir el estado ON porque la lámpara ya está encendida");
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Debes introducir un estado de ON u OFF");
                    Console.WriteLine("");
                }
            } while (true);
        }
    }
}