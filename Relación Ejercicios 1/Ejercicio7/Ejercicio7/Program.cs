Console.WriteLine("Introduzca un número");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca un segundo número");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca un último número");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("El triángulo es equilátero");
}
else if (a == b && b != c)
{
    Console.WriteLine("El triángulo es isósceles");
}
else
{
    Console.WriteLine("El triángulo es escaleno");
}