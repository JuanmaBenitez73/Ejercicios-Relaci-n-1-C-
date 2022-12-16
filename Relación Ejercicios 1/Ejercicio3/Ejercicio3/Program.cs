Console.WriteLine("Introduzca una temperatura en grados Fahrenheit");

double tempF = Convert.ToDouble(Console.ReadLine());
double tempC = ((tempF - 32) / 9 * 5);

Console.WriteLine("La temperatura " + tempF + "ºF en ºC es: " + tempC);