Console.Clear();

int xa = 30, ya = 2,
    xb = 2, yb = 20,
    xc = 60, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xc, y = yc;
int count = 0;

while(count < 6000)
{
    int what = new Random().Next(0, 3);

    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if(what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if(what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
    Console.SetCursorPosition(0, 0);
