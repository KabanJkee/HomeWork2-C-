/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int FirstDigit = number % 10;
int SecondDigit = (number / 10) % 10;
int ThirdDigit = number / 100;
Console.WriteLine("полученное число {0}", SecondDigit );