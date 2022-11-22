//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите 1е число > ");          // Вывод приглашения ввода
string inputValue1 = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value1 = Convert.ToInt32(inputValue1);    // Преобразование строки в число

Console.Write("Введите 2е число > ");          // Вывод приглашения ввода
string inputValue2 = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value2 = Convert.ToInt32(inputValue2);    // Преобразование строки в число

if (value1 > value2) 
{ 
    System.Console.WriteLine("1е число " + value1 + " является наибольшим, а 2е число " + value2 + "  наименьшим"); 
}
else if (value1 == value2)
{
   System.Console.WriteLine("1е число " + value1 + " равняется второму числу (2е число " + value2 + ")"); 
}
else 
{
    System.Console.WriteLine("2е число " + value2 + " является наибольшим, а 1е число " + value1 + "  наименьшим");
}
