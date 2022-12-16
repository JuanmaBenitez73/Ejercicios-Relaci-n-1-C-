Console.WriteLine("Introduce un número entero");
int num = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
bool match = false;

for (int i = 0; i < 5; i++)
{
    int randomNum = random.Next(1, num +1);
    Console.WriteLine(randomNum);

    if (randomNum == num && !match)
    {
        Console.WriteLine("Coincide");
        match = true;
    }
}