Console.Clear();
Console.Write("x= ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y= ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else if (x > 0 && y < 0)
    Console.WriteLine("IV");   