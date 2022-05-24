// Решить задачу с помощью рекурсии.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Программа для поиска суммы чисел в указанном промежутке");
Console.WriteLine("Введите число для начала отсчёта");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число для окончания отсчёта");
int n = Convert.ToInt32(Console.ReadLine()); 
int RecursMNSum(int m, int n)
{
    if (n <= m)
    return 0;
    return n + RecursMNSum(m, n - 1);
}
System.Console.WriteLine($"Сумма цифр указанного промежутка = {RecursMNSum(m, n) + m}");
System.Console.WriteLine();
RecursMNSum(m, n);