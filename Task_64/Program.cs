// Решить задачу с помощью рекурсии.
// Задача 64: Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число для суммирования всех цифр этого числа");
int number = Convert.ToInt32(Console.ReadLine()); // задаём строку для введения числа

static int SumRecurse(int number)
{
    if (number == 0) // Если значение n равно нулю, то мы возвращаем сумму как 0
    return 0;
    
    return(number % 10 + SumRecurse(number / 10)); 
    // Последняя цифра числа суммируется с рекурсивным вызовом второго числа с конца 
}
Console.Write("Сумма цифр указанного числа = " + SumRecurse(number));
System.Console.WriteLine();
SumRecurse(number);
