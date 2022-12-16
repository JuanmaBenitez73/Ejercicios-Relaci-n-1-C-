namespace Ejercicio25
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un número entero");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int result = Factorial(m) - Factorial(n);
            Console.WriteLine($"El resultado de {m}! - {n}! es {result}");
        }
        static int Factorial(int x)
        {
            int fact = 1;
            for (int i = 2; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}