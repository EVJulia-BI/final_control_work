/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] InputArr()
{
    Console.Write("Введите колличество строк в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] ArrWithSizeAl(string[] array, int len)
{
    string[] res = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < len + 1)
        {
            res[j] = array[i];
            j++;
        }
    }
    return res;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arr1 = InputArr();
string[] res1 = ArrWithSizeAl(arr1, 3);
PrintArray(res1);

string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] res2 = ArrWithSizeAl(arr2, 3);
PrintArray(res2);