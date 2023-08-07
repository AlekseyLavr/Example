// // Задача 1. Задайте значение N. Напишите программу, выведет все числа в промежутке от 1 до N.

// Console.Clear();
// Console.WriteLine ("Введите число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ();

// void ShowNumbers (int numberN)
// {
//     if (numberN > 1) ShowNumbers(numberN - 1);
//     Console.WriteLine (numberN + " ");
// }
// ShowNumbers (numberN);

// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Console.Clear();
// Console.WriteLine ("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ();

// int SumDigits (int num)
// {
//     if (num < 0) num *= -1;
//     if (num > 0) return SumDigits(num / 10) + num % 10;
//     else return 0;
// }
// int res = SumDigits(num);
// Console.Write ($"Сумма цифр числа: {res}");

// Задача 3. Задайте значения M и N. Напишите программу, которая выводит все натуральные числа в промежутке от M до N.

// Console.Clear();
// Console.WriteLine ("Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ();

// void ShowNumbersMN (int numM, int numN)
// {
//     Console.Write ($"{Math.Max(numN, numM)} ");
//     if (Math.Min(numM, numN) != Math.Max(numM, numN))
//         ShowNumbersMN(Math.Min(numM, numN), Math.Max(numM, numN) - 1);
// }

// ShowNumbersMN(numM, numN);

// Задача 4. Напишите программу, которая на вход принимает два числа А и В и возводит число А в целую степень В с помощью рекурсии.

Console.Clear();
Console.WriteLine ("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ();

double FindPower (int a, int b)
{
    if (b > 0) 
        return FindPower(a,b - 1) * a;
    if (b < 0)
        return FindPower(a,b + 1) / a;
    return 1.0;
}

double resultFind = FindPower(a, b);
Console.Write ($"A в степени B: {resultFind}");