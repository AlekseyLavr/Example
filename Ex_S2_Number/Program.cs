Console.Clear();
int f(int n)
{
    int n1 = n / 10;
    int n2 = n % 10;
    if (n1 > n2)
        return n1;
    return n2;        
}

int n = new Random().Next(10, 100);
Console.WriteLine(n);
Console.WriteLine(f(n));