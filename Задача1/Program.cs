/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введи трёхзначное число: ");
int input = int.Parse(Console.ReadLine());
if (input > 0)
{
Console.WriteLine((input%100-input%10)/10);
}
if (input < 0)
{

Console.WriteLine((-1*(input%100-input%10)/10));
}
