using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduce la cantidad de números:");
int cant = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce ahora " + cant + " números:");

double suma = 0;

for (int i = 0; i < cant; i++)
{
    suma = suma + Convert.ToDouble(Console.ReadLine());
}

double media = suma / cant;

Console.WriteLine("La media de esos números es: " + media);