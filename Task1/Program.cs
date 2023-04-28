/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трёхзначное число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.Write("Error");
    return;
}
if (a >= 1000)
{
    Console.Write("Error");
    return;
}
else
{
    int b = a / 10;
    int c = b % 10;
    Console.Write($"->{c}");
}