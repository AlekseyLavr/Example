// See https://aka.ms/new-console-template for more information

// Строчный массив

// string[,] table = new string[2, 3];
// table[1, 2] = "world";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int cols = 0; cols < 3; cols++)
//     {
//         Console.WriteLine($"-{table[rows, cols]}-");
//     }
// }

// Числовой массив (матрица)

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// int[,] matrix = new int[3, 4];
// FillArray(matrix);

// Факториал
// int Factorial(int n)
// {
//     if (n == 0) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(3));

// Код Фибоначчи
int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(Fibonacci(i));
}
