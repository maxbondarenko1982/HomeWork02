﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

Console.Write("Введите число больше 99: ");
var number =Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("В введенном числе третьей циры нет");
    if (number < 100)
    {
        Console.Write("Введите число больше 99: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    if (number < 100)
    {
        Console.Write("Ошибка ввода");
    }

}
if (number >= 100)
{
    while (number > 999)
    {
    number = number / 10;
    }
    {
    number = number % 10;
    }
Console.WriteLine($"Третья цифра введенного числа : {number}");
}
