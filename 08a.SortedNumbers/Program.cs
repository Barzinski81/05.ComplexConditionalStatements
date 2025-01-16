int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

bool asc = (numberOne < numberTwo && numberTwo < numberThree);
bool desc = (numberOne > numberTwo && numberTwo > numberThree);

switch (asc)
{
    case true:
        Console.WriteLine("Ascending");
        break;
    case false:
        switch(desc)
        {
            case true:
                Console.WriteLine("Descending");
                break;
            case false:
                Console.WriteLine("Not sorted");
                break;
        }
        break;
}