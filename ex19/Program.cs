// Задача 19. Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");
string? strArray = Console.ReadLine();

if (strArray?.Length == 5)
{
    if (strArray[0] == strArray[4] && strArray[1] == strArray[3])
    System.Console.WriteLine("Число является Палиндромом");
    else
    System.Console.WriteLine("Число НЕ является Палиндромом");
}
else
    System.Console.WriteLine("Введено не пятизначное число!");