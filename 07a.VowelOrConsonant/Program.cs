char letter = char.Parse(Console.ReadLine());

switch (letter)
{
    case 'A'or 'a' or 'E' or 'e' or 'I' or 'i' or 'O' or 'o' or 'U' or 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Consonant");
        break;
}


// Alternative version:

char letter = char.Parse(Console.ReadLine());

bool vowel = (letter == 'A' || letter == 'a' || letter == 'E' || letter == 'e' || letter == 'I' || letter == 'i' || letter == 'O' || letter == 'o' || letter == 'U' || letter == 'u');

switch (vowel)
{
    case true:
        Console.WriteLine("Vowel");
        break;
    case false:
        Console.WriteLine("Consonant");
        break;
}
