string movie = Console.ReadLine();
double rows = double.Parse(Console.ReadLine());
double seats = double.Parse(Console.ReadLine());

double price = 0;

if (movie == "Premiere")
{
    price = 12.00 * rows * seats;
}
else if (movie == "Normal")
{
    price = 7.50 * rows * seats;
}
else if (movie == "Discount")
{
    price = 5.00 * rows * seats;
}

Console.WriteLine($"{price:F2}");