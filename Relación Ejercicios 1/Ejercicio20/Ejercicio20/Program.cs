namespace Ejercicio20
{
    class Program
    {
        enum MonthOfYear { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Ocubre, Noviembre, Diciembre }
        static MonthOfYear monthOfYear = MonthOfYear.Enero;

        static void Main()
        {
            Console.WriteLine("Introduce un numero del 1 al 12 correspondiente a los meses del año");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 12)
            {
                MonthOfYear mes = (MonthOfYear)num;
                Console.WriteLine(mes);
            }
            else
            {
                Console.WriteLine("Debe introducir un numero comprendido entre el 1 y el 12");
            }
        }
    }
}