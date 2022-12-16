using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduzca un número");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca un segundo número");
double num2 = Convert.ToDouble(Console.ReadLine());

double suma = num1 + num2;
Console.WriteLine("El resultado de la suma de " + num1 + " + " + num2 + " es: " + suma);