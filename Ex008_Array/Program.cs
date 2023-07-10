int [] array = {1, 12, 33, 81, 52, 6, 27, 81, 19};
int n = array.Length;
int find = 81;
int i = 0;
while (i < n)
{
    if (array[i] == find)
    {
       Console.WriteLine(i);
       break; 
    }
    i++;
}