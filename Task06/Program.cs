//Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 1/4

System.Console.WriteLine("введите число > ");

double numer = Convert.ToInt32(Console.ReadLine());
double resalt = 1/numer;

System.Console.WriteLine($"{resalt}");

