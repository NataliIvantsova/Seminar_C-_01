// Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7

System.Console.WriteLine("введите число > ");

double numer = Convert.ToInt32(Console.ReadLine());
if(numer>=0)
{
    System.Console.WriteLine($"модулем числа {numer} является квадратом числа {numer}");
}
else
{
        System.Console.WriteLine($"число {numer} не  является квадратом числа {numer/-1}");
}

