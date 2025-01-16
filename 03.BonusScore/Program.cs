int pts = int.Parse(Console.ReadLine());

if (pts >= 0 && pts <= 3)
{
    pts += 5;
}
else if (pts >=4 && pts <=6)
{
    pts += 15;
}
else if (pts >=7 && pts <=9)
{
    pts += 20;
}

Console.WriteLine(pts);