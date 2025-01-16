int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

bool one = firstNumber > secondNumber;
bool two = firstNumber > thirdNumber;
bool three = secondNumber > thirdNumber;

switch (one)
{
    case true:
        switch (two)
        {
            case true:
                Console.WriteLine(firstNumber);
                break;
            case false:
                Console.WriteLine(thirdNumber);
                break;
        }
        break;
    case false:
        {
            switch (three)
            {
                case true:
                    Console.WriteLine(secondNumber);
                    break;
                case false:
                    Console.WriteLine(thirdNumber);
                    break;
            }
        }
        break;
}