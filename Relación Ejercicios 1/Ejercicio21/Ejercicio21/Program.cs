namespace Ejercicio21
{
    class Program
    {
        enum DayOfWeek { Lunes = 1, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo }

        static void Main()
        {
            Console.WriteLine("Introduce un día de la semana");
            
            DayOfWeek dia = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);
            int num = (int)dia;
            
            if (num <= 5)
            {
                Console.WriteLine("Día Laboral");
                
            }
            else
            {
                Console.WriteLine("Día No Laboral");
            }
        }
    }
}