/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

System.Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7){
         Console.Write("Такого дня недели не существует, введите корректное число: ");
         number = Convert.ToInt32(Console.ReadLine());}
            if (number < 1 && number > 7)
               Console.Write("Ошибка ввода");

       
else 
    if (number == 6){
    System.Console.WriteLine("Это суббота!");
}
    if (number == 7){
    System.Console.WriteLine("Это воскресенье!");
}
    if (number >=1 && number <=5){
    System.Console.WriteLine("Это будний день(((");
}
