// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Задача 25: Возвести заданное число в заданную степень");

Console.Write("Введите число, которое будем возводить в степень:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение степени, в которую будем возводить заданное Вами число:  ");
int degree = Convert.ToInt32(Console.ReadLine());

void Exponentiation (int degree, int number)
{
    int result = number;
    for (int i=1; i<degree;i++)
{
    result = result * number;
}
Console.WriteLine($"Возведем {number} в степень {degree}, получаем = {result}");
}
 
Exponentiation (degree, number);
