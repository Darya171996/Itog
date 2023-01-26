// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] Array()
{
    string[] array = new string[new Random().Next(1, 5)];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] array1 = Array();

void PrintArray()
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
            Console.Write($"\"{array1[i]}\" ");
    }
}

PrintArray();