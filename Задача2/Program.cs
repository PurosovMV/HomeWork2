/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введи любое число");
int A = int.Parse(Console.ReadLine());
if (A == 0)
{
    Console.WriteLine("Нет третьей цифры");
}
if (A > 0)
{
    int digitalCount = (int)Math.Log10(A) + 1;
    if (digitalCount < 3)
    {
        Console.WriteLine("Нет третьей цифры");
    }
    else
    {
        int n = Convert.ToInt32(Math.Pow(10, digitalCount - 2));
        int m = Convert.ToInt32(Math.Pow(10, digitalCount - 3));

        Console.WriteLine(A % n / m);
    }
}
if (A < 0)
{
    int newA = A * -1;
    int digitalCount = (int)Math.Log10(newA) + 1;
    if (digitalCount < 3)
    {
        Console.WriteLine("Нет третьей цифры");
    }
    else
    {
        int n = Convert.ToInt32(Math.Pow(10, digitalCount - 2));
        int m = Convert.ToInt32(Math.Pow(10, digitalCount - 3));

        Console.WriteLine(newA % n / m);
    }
}