// See https://aka.ms/new-console-template for more information
// Различные функции:
// 1 2 5 4 3
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// "1 2 5 4"
// "1", "2", "5", "3"
// 1, 2, 5, 3
// [1, 2, 5, 3]
// Console.WriteLine($"[{string.Join(", ", array)}]");

// foreach (int i in array)
//     Console.WriteLine(i);
// вывод: 
//          1
//          5
//          4
//          7
// Задача 39: Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 10); 
// }

// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i ++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Массив:              [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Перевёрнутый массив: [{string.Join(", ", array)}]");

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
// 5 7 8 -> yes
// 1 1 5 -> no

// Console.Clear();
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// if (array[0] < array[1] + array[2]
//     && array[1] < array[0] + array[2]
//     && array[2] < array[0] + array[1])
//     Console.WriteLine("YES");
// else
// {
//     Console.WriteLine("NO");
// }    


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string res = String.Empty;
// while (n > 0)
// {
//     res = Convert.ToString(n % 2) + res;
//     n /= 2;
// }
// Console.WriteLine(res);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n0 = 0;
// int n1 = 1;
// int n2;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{n0} ");
//     n2 = n0 + n1;
//     n0 = n1;
//     n1 = n2;
// }

// Задача 45: Напишите программу, которая будет 
// создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();
Console.Write("Bведите массив: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[] array2 = new int[array.Length];

for (int i = 0; i < array2.Length; i++)
    array2[i] = array[i];
Console.WriteLine($"[{string.Join(", ", array2)}]");