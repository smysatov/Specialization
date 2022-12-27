//Написать программу, которая из имеющегося массива строк формирует
//массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться
//коллекциями, лучше обойтись исключительно массивами.

string[] array1 = FillArray();
Console.Write("Ваш Массив: ");
PrintArray(array1);
Console.WriteLine();

string[] array2 = new string[array1.Length];
SortArray(array1, array2);
Console.Write("Ваш новый массив из эл. длинной не более 3 символов: ");
PrintArray(array2);

string[] FillArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

void SortArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
