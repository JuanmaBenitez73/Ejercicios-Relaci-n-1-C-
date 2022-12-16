Console.WriteLine("Introduzca su edad");

int age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Menor de edad");
}
else if (age < 65)
{
    Console.WriteLine("Activo");
}
else
{
    Console.WriteLine("Jubilado");
}