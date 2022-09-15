// Задача 29: Напишите программу, которая задаёт массив из 8(?) элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Задача 29: Получить массив из N элементов и вывести его на экран.");
Console.Write("Введите количество элементов массива:  ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"В нашем массиве будет {N} элементов.");

int [] array = new int [N];

// Получим элементы массива
for (int i=0;i<array.Length; i++)
{
    Console.Write($"Введите {i}-й элемент массива:  ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Получен массив из {array.Length} элементов.");
Console.Write($"[ ");
for (int i=0;i<array.Length;i++)
{
Console.Write($"{array[i]}");
if (i<(array.Length-1))
{
        Console.Write(", ");
}
}
Console.Write(" ]");