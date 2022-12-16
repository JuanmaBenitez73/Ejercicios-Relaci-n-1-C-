using System.Globalization;

namespace Ejercicio28
{
    class Program
    {
        enum Figuras { Circulo, Triangulo, Cuadrado}
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Elige una figura (Círculo, Triángulo o Cuadrado):");
            Figuras figura = (Figuras)Enum.Parse(typeof(Figuras), Console.ReadLine(), true);

            double area = 0;

            switch (figura)
            {
                case Figuras.Circulo:
                    area = AreaCirculo();
                    break;

                case Figuras.Triangulo:
                    area = AreaTriangulo();
                    break;

                case Figuras.Cuadrado:
                    area = AreaCuadrado();
                    break;
            }
            Console.WriteLine($"El área de {figura} es {area}");
        }
        static double AreaCirculo()
        {
            Console.WriteLine("Introduce el radio del círculo");
            double radio = double.Parse(Console.ReadLine());

            return Math.PI * Math.Pow(radio, 2);
        }
        static double AreaTriangulo()
        {
            Console.WriteLine("Introduce la base del triángulo");
            double @base = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triángulo");
            double altura = double.Parse(Console.ReadLine());

            return @base * altura / 2;
        }
        static double AreaCuadrado()
        {
            Console.WriteLine("Introduce el lado del cuadrado");
            double lado = double.Parse(Console.ReadLine());

            return lado * lado;
        }
    }
}