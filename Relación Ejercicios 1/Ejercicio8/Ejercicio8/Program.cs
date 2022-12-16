Console.WriteLine("Introduce un número de 2 cifras");

int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10 * 10 + num / 10;

Console.WriteLine("El número " + num + " invertido es: " + result);