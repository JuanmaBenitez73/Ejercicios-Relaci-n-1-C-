Console.WriteLine("Introduce un número en base 10");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce la base a la que convertirlo");
int numBase = Convert.ToInt32(Console.ReadLine());

string resultado = "";
string resultado2 = "";

if (numBase > 1 && numBase < 10)
{
	for (int i = num; num > 0; i--)
	{
		int resto = num % numBase;
		num /= numBase;
		resultado += resto;
	}
	for (int i = resultado.Length - 1; i >= 0; i--)
	{
		resultado2 += resultado[i];
	}
	Console.WriteLine(resultado2);
}
else
{
	Console.WriteLine("Escriba un un número comprendido entre 2 y 9");
}