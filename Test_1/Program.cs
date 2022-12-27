//Написать программу, которая из имеющегося массива строк формирует
//массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться
//коллекциями, лучше обойтись исключительно массивами.

string[] array = FillArray();
PrintArray(array);
Console.WriteLine();

string[] FillArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

void PrintArray(string[] array)
{
    int length = array.Length;
    Console.Write("Ваш Массив: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
