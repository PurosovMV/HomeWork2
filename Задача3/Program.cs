/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введи номер дня недели (от 1 до 7): ");
string numberDay = Console.ReadLine();
switch (numberDay)
{
    case "6":
        Console.WriteLine($"{numberDay} - > Да");
        break;
    case "7":
        Console.WriteLine($"{numberDay} - > Да");
        break;
    default:
        Console.WriteLine($"{numberDay} - > Нет");
        break;
}