namespace Ejercicio23
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Introduce dos números enteros:");
                string linea1 = Console.ReadLine();
                string linea2 = Console.ReadLine();
                int num1 = int.Parse(linea1);
                int num2 = int.Parse(linea2);
                int result = num1 / num2;
                Console.WriteLine($"La división es {num1}:{num2} = {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Debes introducir números enteros");
                Console.WriteLine("Introduce dos números enteros:");
                string linea1 = Console.ReadLine();
                string linea2 = Console.ReadLine();
                int num1 = int.Parse(linea1);
                int num2 = int.Parse(linea2);
                int result = num1 / num2;
                Console.WriteLine($"La división es {num1}:{num2} = {result}");
            }
        }
    }
}