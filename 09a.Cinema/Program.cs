string movie = Console.ReadLine();
double rows = double.Parse(Console.ReadLine());
double seats = double.Parse(Console.ReadLine());

double price = 0;

switch(movie)
{
    case "Premiere":
        price = 12.00 * rows * seats;
        break;
    case "Normal":
        price = 7.50 * rows * seats;
        break;
    case "Discount":
        price = 5.00 * rows * seats;
        break;
    default:
        break;
}

Console.WriteLine($"{price:F2}");