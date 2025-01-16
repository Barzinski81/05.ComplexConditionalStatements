string product = (Console.ReadLine());
string day = (Console.ReadLine());

switch (product)
{
    case "Banana":
        switch (day)
        {
            case "Weekday":
                Console.WriteLine("2.50");
                break;
            case "Weekend":
                Console.WriteLine("2.70");
                break;
            default:
                break;
        }
        break;
    case "Apple":
        switch (day)
        {
            case "Weekday":
                Console.WriteLine("1.30");
                break;
            case "Weekend":
                Console.WriteLine("1.60");
                break;
            default:
                break;
        }
        break;
    case "Kiwi":
        switch (day)
        {
            case "Weekday":
                Console.WriteLine("2.20");
                break;
            case "Weekend":
                Console.WriteLine("3.00");
                break;
            default:
                break;
        }
        break;
    default:
        break;
}


