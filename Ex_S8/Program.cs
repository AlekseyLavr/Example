//Задача 1.
//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.

// int [,] InputArray (int rows, int collumns)
// {
//     int [,] createdArray = new int[rows, collumns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < collumns; j++)
//             createdArray[i,j] = new Random().Next(0,10);
//     return createdArray;
// }

// void PrintArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             Console.Write (showedArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ChangeRows (int row1, int row2, int [,] arrayToChange)
// {
//     if (row1 >= 0
//      && row1 < arrayToChange.GetLength(0)
//      && row2 >= 0
//      && row2 < arrayToChange.GetLength(0))
//      {
//         for (int j = 0; j < arrayToChange.GetLength(1); j++)
//         {
//             int temp = arrayToChange[row1,j];
//             arrayToChange[row1,j] = arrayToChange[row2,j];
//             arrayToChange[row2,j] = temp;
//         }
//         PrintArray(arrayToChange);
//      }
//     else
//         Console.WriteLine("Error! Impossible value!");
// }

// Console.Clear();
// Console.Write("Enter count of rows: ");
// int userRows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter count of collumns: ");
// int userCollumns = Convert.ToInt32(Console.ReadLine());

// int [,] firstTaskArray = InputArray(userRows, userCollumns);
// PrintArray(firstTaskArray);

// Console.Write("Enter number of the first row to remove: ");
// int userRowFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of the second row to remove: ");
// int userRowSecond = Convert.ToInt32(Console.ReadLine());

// ChangeRows(userRowFirst, userRowSecond, firstTaskArray);

//Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.Clear();
// Console.WriteLine("Введите кол-во строк: ");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите кол-во столбцов: ");
// int collums = int.Parse(Console.ReadLine());

// int[,] array = new int[rows, collums];

// InputArray(array);
// ChangeRowCollum(array);
// PrintArray(array);

// void ChangeRowCollum(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//         return;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          // столбец
//         for (int j = 0; j < i; j++)
//         {
//             int temp = array[j,i];
//             array[j,i] =  array[i, j];
//             array[i,j] = temp;// строка
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void InputArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     PrintArray(array);
// }

//Задача 3.
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.

int [,] InputArray (int rows, int collumns)
{
    int [,] createdArray = new int[rows, collumns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
            createdArray[i,j] = new Random().Next(0,10);
    return createdArray;
}

void PrintArray (int [,] showedArray)
{
    for (int i = 0; i < showedArray.GetLength(0); i++)
    {
        for (int j = 0; j < showedArray.GetLength(1); j++)
        {
            Console.Write (showedArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MinVal(int[,] arrayMin)
{
    int[] numberRowColl = new int[2];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < arrayMin.GetLength(0); i++)
        for (int j = 0; j < arrayMin.GetLength(1); j++)
            if (arrayMin[i,j] < arrayMin[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
    numberRowColl[0] = iMin;
    numberRowColl[1] = jMin;
    return numberRowColl;
}

int[,] ZeroRowColl(int[] arrayIndex, int[,] arrayVal)
{
    for (int i = 0; i < arrayVal.GetLength(1); i++)
        arrayVal[arrayIndex[0],i] = 0;
    for (int i = 0; i < arrayVal.GetLength(0); i++)
        arrayVal[i,arrayIndex[1]] = 0;
    return arrayVal;        
}

Console.Clear();
Console.Write("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter count of collumns: ");
int userCollumns = Convert.ToInt32(Console.ReadLine());

int [,] firstTaskArray = InputArray(userRows, userCollumns);
PrintArray(firstTaskArray);

int[] indexArray = MinVal(firstTaskArray);
int[,] finishArray = ZeroRowColl(indexArray, firstTaskArray);
PrintArray(finishArray);