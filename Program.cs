//   Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []


string[] arr = new string[4] { "he1", "23", "wor", ":-)" };
int len = 0;
void SecondArray(string[] arr, out int len)
{
    len = 0;
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            len = count;
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
