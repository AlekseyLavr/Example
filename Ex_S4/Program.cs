// Принимиает на вход число (А) и выдает сумму чисел от 1 до А.
// double f (double n)
// {
//     return (1 + n) / 2 * n;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int f (int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         n /= 10;
//         count++;
//     }
//     return count;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// void f(int n)
// {
//     int result = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     Console.WriteLine(result);
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// f(n);

// Задача 30: Напишите программу, которая выводит массив из 8 
// элементов, заполненный нулями и единицами.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
Console.WriteLine($"[{string.Join(", ", array)}]");