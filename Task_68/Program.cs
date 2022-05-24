// Решить задачу с помощью рекурсии.
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

System.Console.WriteLine();
System.Console.WriteLine("***ВНИМАНИЕ*** Не вводите большие числа! \n");
System.Console.WriteLine("Функция Аккермана A(m,n) растёт очень быстро \nи принимает на ввод два неотрицательных целых числа.");
System.Console.WriteLine();
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine()); 
int RecurseAkkerman(int m, int n)
{
    if (m == 0) return n + 1;

    else if((m > 0) && (n == 0)) return RecurseAkkerman(m - 1, 1);

    else if((m > 0) && (n > 0)) return RecurseAkkerman(m - 1, RecurseAkkerman(m, n - 1));
    
    else return n + 1;
}
Console.WriteLine($"Результатом этой функции будет являться число = {RecurseAkkerman(m, n)}");
System.Console.WriteLine();
