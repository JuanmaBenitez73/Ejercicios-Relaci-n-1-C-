namespace Ejercicio30
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Intorduce un número");
            int filas = int.Parse(Console.ReadLine());

            for(int i = 1; i <= filas; i++)
            {
                int spacios = filas - i;
                Console.Write(new String(' ', spacios));
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(Combinatorio(i, j));
                    if(j < i) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static int Combinatorio(int m, int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }
        static int Factorial(int x)
        {
            int result = 1;
            
            for(int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}