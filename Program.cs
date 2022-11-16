string[] arr = new string[3] {"Russia", "Denmark", "Kazan"};
string[] arr2 = new string[arr.Length];
void SecondArray(string[] arr, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        arr2[count] = arr[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
} SecondArray(arr, arr2);
PrintArray(arr2);