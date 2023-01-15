// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.WriteLine("Введите номер дня недели от 1 до 7");
string day = Console.ReadLine();//читай строку день как
int a = Convert.ToInt32(day);
if(a==1)
{
    System.Console.WriteLine($"День недели {a} - понедельник");
}
else if(a==2)
{
    System.Console.WriteLine($"День недели {a} - вторник");
}
else if(a==3)
{
    System.Console.WriteLine($"День недели {a} - среда");
}
else if(a==4)
{
    System.Console.WriteLine($"День недели {a} - четверг");
}
else if(a==5)
{
    System.Console.WriteLine($"День недели {a} - пятница");
}
else if(a==6)
{
    System.Console.WriteLine($"День недели {a} - суббота");
}
else if(a==7)
{
    System.Console.WriteLine($"День недели {a} - воскресенье");
}