namespace Ejercicio36
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce numeros enteros separados por comas");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',');

            int[] numerosDeVerdad = new int[numerosDivididos.Length];

            for (int i = 0; i < numerosDivididos.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(numerosDivididos[i]);
            }

            int aux;
            
            for (int i = 0; i < numerosDeVerdad.Length; i++)
            {
                for (int j = 0; j < numerosDeVerdad.Length; j++)
                {
                    if (numerosDeVerdad[i] > numerosDeVerdad[j + 1])
                    {
                        aux = numerosDeVerdad[j];
                        numerosDeVerdad[j] = numerosDeVerdad[j + 1];
                        numerosDeVerdad[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine(String.Join(",", numerosDeVerdad));
        }
    }
}