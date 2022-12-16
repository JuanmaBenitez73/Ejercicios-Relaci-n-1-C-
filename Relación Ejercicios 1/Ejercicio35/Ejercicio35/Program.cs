namespace Ejercicio35
{
    class Program
    {
        const string LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";
        static void Main()
        {
            Console.WriteLine("Introduce los números de tu DNI");
            int dni = int.Parse(Console.ReadLine());
            char letter = LETTERS[dni % LETTERS.Length];

            Console.WriteLine($"Tu DNI es {dni}{letter}");
        }
    }
}