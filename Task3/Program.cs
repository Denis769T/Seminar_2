/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите день недели, в виде цифры:");
int b = Convert.ToInt32(Console.ReadLine());

switch (b)
{
    case 7:
        Console.Write($"{b}->Да");
        break;
    case 6:
        Console.Write($"{b}->Да");
        break;
    case 5:
        Console.Write($"{b}->Нет");
        break;
    case 4:
        Console.Write($"{b}->Нет");
        break;
    case 3:
        Console.Write($"{b}->Нет");
        break;
    case 2:
        Console.Write($"{b}->Нет");
        break; 
    case 1:
        Console.Write($"{b}->Нет");
        break;             
}
