// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

uint Ackermann(uint m, uint n)
{
    if (m == 0) return n + 1;
    else
    {
        if ((m != 0) && (n == 0)) return Ackermann(m - 1, 1);
        else return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

try
{
    Console.Write("Введите первое неотрицательное число:\t");
    uint number1 = Convert.ToUInt32(Console.ReadLine());
    Console.Write("Введите второе неотрицательное число:\t");
    uint number2 = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine($"Значение функции Аккермана: А({number1}, {number2}) = {Ackermann(number1, number2)}");
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}