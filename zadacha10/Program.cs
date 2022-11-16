/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 999)
{
    number = number%100/10;
    Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("Неверное число");
}
