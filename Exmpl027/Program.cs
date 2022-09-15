// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Задача 27: Найдем сумму цифр в заданном числе.");
Console.Write("Введите число: ");
//Console.WriteLine();
int summ = 0; 
string number = Convert.ToString(Console.ReadLine());
//Console.WriteLine($"Введенное число состоит из {number.Length} символов");

   for (int i=0;i<number.Length;i++)
    {
      summ = summ + int.Parse(number[i].ToString());
      //Console.WriteLine($"Переменная array равняется {number[i]}");
      //Console.WriteLine($"Переменная Сумма равняется {summ}");
    }

Console.WriteLine($"Сумма цифр в числе {number} равняется {summ}");
