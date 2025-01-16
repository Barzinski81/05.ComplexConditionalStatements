int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

if (numberOne < numberTwo && numberTwo < numberThree)
{
    Console.WriteLine("Ascending");
}
else if (numberOne > numberTwo && numberTwo > numberThree)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}