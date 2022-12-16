Console.WriteLine("Introduce el texto");
string text = Console.ReadLine();
string consulted = "";

for (int i = 0; i < text.Length; i++)
{
    char caracter = text[i];

    if (char.IsLetter(caracter) && !consulted.Contains(caracter))
    {
        int count = 0;

        for (int j = 0; j < text.Length; j++)
        {
            if (caracter == text[j]) count++;
        }
        Console.WriteLine($"{caracter}: {count}");
        consulted += caracter;
    }
}