Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Последнее число: {a % 10}");