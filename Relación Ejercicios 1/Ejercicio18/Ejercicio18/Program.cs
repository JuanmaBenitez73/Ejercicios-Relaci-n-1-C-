namespace Ejercicio18
{
    class Program 
    {
        static void Main()
        { 
            Console.WriteLine("Introduce la cantidad de números:");
            int cant = Convert.ToInt32(Console.ReadLine());
    
            Console.WriteLine($"Introduce {cant} números");
            double num, media;
            double cuad = 0;

            for (int i = 0; i < cant; i++)
            {
                num = Convert.ToDouble(Console.ReadLine());
                cuad += Math.Pow(num, 2);
            }
            media = Math.Sqrt(cuad / cant);
            Console.WriteLine($"La media cuadrática de esos números es: {media}");
        }
    }
}
