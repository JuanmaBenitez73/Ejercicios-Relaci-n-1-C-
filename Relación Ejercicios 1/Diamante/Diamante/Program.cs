using System.Text;

Console.WriteLine("Introduce la mitad de cuantas lineas sera el diamante");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
int spaces, asterisks;

StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < size; i++)
{
    spaces = size - i;
    asterisks = 2 * i + 1;

    stringBuilder.Append(new string(' ', spaces));
    stringBuilder.AppendLine(new string('*', asterisks));
}
for (int i = size - 2; i >= 0; i--)
{
    spaces = size - i;
    asterisks = 2 * i + 1;

    stringBuilder.Append(new string(' ', spaces));
    stringBuilder.AppendLine(new string('*', asterisks));
}

Console.WriteLine(stringBuilder.ToString());