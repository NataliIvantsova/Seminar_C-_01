/*Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

System.Console.Write("Введите число > ");
String stringValue = Console.ReadLine();//заводим строку и преобразуем её в число
int value = Convert.ToInt32(stringValue);//convert дает значение целых чисел

int result = value * value;

System.Console.WriteLine("Квадрат числа " + value + " равен " + result);
System.Console.WriteLine($"Квадрат числа {value} равен {result}");// $ признак того что строка будет в дальнейшем иметь автоподстановку