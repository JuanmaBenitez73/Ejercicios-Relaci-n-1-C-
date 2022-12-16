using System.Globalization;

namespace Ejercicio29
{
    class Program
    {
        const double Euro_a_Libra = 0.86;
        const double Euro_a_Dólar = 1.28611;
        const double Euro_a_Yen = 129.852;
        enum Moneda { libras, dolares, yenes }
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Elige una moneda (libras, dolares o yenes):");
            string moneda = Console.ReadLine();

            Console.WriteLine("Introduce los Euros");
            double euros = double.Parse(Console.ReadLine());

            Conversión(euros, moneda);
        }
        static void Conversión(double euros, string moneda)
        {
            object currency;
            if (Enum.TryParse(typeof(Moneda), moneda, true, out currency))
            {
                double result = 0;

                switch ((Moneda)currency)
                {
                    case Moneda.libras:
                        result = euros * Euro_a_Libra;
                        break;

                    case Moneda.dolares:
                        result = euros * Euro_a_Dólar;
                        break;

                    case Moneda.yenes:
                        result = euros * Euro_a_Yen;
                        break;
                }
                Console.WriteLine($"{euros} euros son {result} {currency}");
            }
            else 
            {
                Console.WriteLine("No conozco esa moneda");
            }
        }
    }
}