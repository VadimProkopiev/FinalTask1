string[] arr = new string[5] { "Rus", "De", "Ka", "43", "434y975" };
int len = 1;
void SecondArray(string[] arr, out int len)
{
    len = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            len = count + 1;
            count++;
        }
    }
}
SecondArray(arr, out len);
Console.WriteLine(len);
string[] arr2 = new string[len];
void SecondArrayFind(string[] arr, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
}
SecondArrayFind(arr, arr2);

void PrintArray(string[] array)
{
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

SecondArrayFind(arr, arr2);
PrintArray(arr2);
