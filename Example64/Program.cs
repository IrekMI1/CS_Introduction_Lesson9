// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintRange(int m, int n)
{
    if (m > n) Console.WriteLine("Первое число больше, чем второе!");
    else if (m == n) Console.Write($"{m}");
    else
    {
        Console.Write($"{m}, ");
        PrintRange(m + 1, n);
    }
}

try
{
    Console.Write("Введите первое число:\t");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число:\t");
    int number2 = Convert.ToInt32(Console.ReadLine());
    PrintRange(number1, number2);
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}