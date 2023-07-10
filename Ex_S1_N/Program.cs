Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = -1 * a;
while (i <= a)
{
    Console.WriteLine($"{i} ");
    i++;
}