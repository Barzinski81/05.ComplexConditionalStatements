int number = int.Parse(Console.ReadLine());

bool valid = ((number >= 100 && number <= 200) || number == 0);

switch(valid)
{
    case false:
        Console.WriteLine("invalid");
        break;
    default:
        break;
}