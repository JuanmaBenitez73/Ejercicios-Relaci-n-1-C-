Console.WriteLine("Introduce un número entero para la semilla");
int semilla = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce un número entero para la cantidad de caracteres");
int numcaract = Convert.ToInt32(Console.ReadLine());

Random random = new Random(semilla);

for (int i = 0; i < numcaract; i++)
{
    int ascii = random.Next(256);
    Console.Write((char)ascii);
}