Console.WriteLine("Introduce un número:");

int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
    bool esPrimo = true;
	for (int j = 2; j <= i / 2 && esPrimo; j++)
	{
		if (i % j == 0) esPrimo = false;
	}
	if (esPrimo) Console.WriteLine(i);
}