// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetRangeSum(int m, int n)
{
    if (m == n) return n;
    else return m + GetRangeSum(m + 1, n);
}

try
{
    Console.Write("Введите первое число:\t");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число:\t");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2) Console.WriteLine("Первое число больше, чем второе!");
    else Console.WriteLine("Сумма элементов от {0} до {1} равно {2}", number1, number2, GetRangeSum(number1, number2));
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}