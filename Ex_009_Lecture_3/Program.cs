// Вид 1
// void Metod1()
// {
//     Console.WriteLine("Автор...");
// }
// Metod1();



// Вид 2
// void Metod2(string ghj)
// {
//     Console.WriteLine(ghj);
// }
// Metod2("Text");

// Именованные аргументы
// void Metod21 (string ghj, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine (ghj);
//         i++;
//     }
// }
// Metod21 ("Text", 4);
// Metod21 (ghj: "Text", count: 4);
// или
// Metod21 (count: 3, ghj: "Text");




// Вид 3
// Когда что-то приходит на вход необходимо указывать тип данных
// int Metod3()
// {
//     return DateTime.Now.Year;
// }
// int year = Metod3();
// Console.WriteLine(year);


// Вид 4
// string Metod4( int count, string c)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Metod4(10, "Z ");
// Console.WriteLine(res);





// Вид 4 с циклом for
// string Metod4( int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;    
// }
// string res = Metod4(10, "Z ");
// Console.WriteLine(res);



// Таблица умножения


// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Текст

// string text = "- Я думаю, - сказал князь, улыбаясь, -что,"
//               + "ежели бы вас послали вместо нашего милого Винцента,"
//               + "Вы бы взяли приступом согласие прусского короля."
//               + "Вы так красноречивы. Вы дадите мне чаю?";
// string Replase (string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++) 
//     {
//         if (text[i] == oldValue)
//             result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replase(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, 'С', 'с');
// Console.WriteLine(newText);



// Алгоритм "методом выбора" min
// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// void SelectionSort (int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// Алгоритм "методом выбора" max
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);