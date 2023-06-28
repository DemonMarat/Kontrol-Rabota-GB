// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
string[] ResultArray(string[] array)
{
    int c = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) c += 1;
    }
    string[] arrayRes = new string[c];
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            arrayRes[j] = array[i];
            j += 1;
        }
    }
    return arrayRes;
}
string[] arrayFaсt = CreateArray();
Console.WriteLine();
Console.WriteLine("Созданный массив:");
ShowArray(arrayFaсt);
Console.WriteLine();
string[] arrayRes = ResultArray(arrayFaсt);
Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
ShowArray(arrayRes);
