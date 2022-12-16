Console.WriteLine("Introduce una letra");

string EstadoCivil = Console.ReadLine();
EstadoCivil = EstadoCivil.ToUpper();

switch (EstadoCivil)
{
	case "C":
		Console.WriteLine("Casada");
		break;
    case "S":
        Console.WriteLine("Soltera");
        break;
    case "V":
        Console.WriteLine("Viuda");
        break;
    case "D":
        Console.WriteLine("Divorciada");
        break;
    default:
        Console.WriteLine("No existe un estado civil con esa letra");
		break;
}