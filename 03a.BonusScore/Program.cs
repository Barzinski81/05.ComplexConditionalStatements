int pts = int.Parse(Console.ReadLine());

bool one = (pts >= 0 && pts <= 3);
bool two = (pts >= 4 && pts <= 6);
bool three = (pts >= 7 && pts <= 9);

switch (one)
{
    case true:
        pts += 5;
        break;
    case false:
        switch (two)
        {
            case true:
                pts += 15;
                break;
            case false:
                switch (three)
                {
                    case true:
                        pts += 20;
                        break;
                }
                break;
        }
        break;
}

Console.WriteLine(pts);