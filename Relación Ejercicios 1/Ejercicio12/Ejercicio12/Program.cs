Console.WriteLine("Escribe una palabra");
string word = Console.ReadLine();

bool esPalindromo = true;

for (int i = 0; i < word.Length && esPalindromo; i++)
{
    if (word[i] != word[word.Length - i - 1])
    {
        esPalindromo = false;
    }
}
if (esPalindromo)
{
    Console.WriteLine($"La palabra {word} es un palíndromo");
}
else
{
    Console.WriteLine($"La palabra {word} no es un palíndromo");
}