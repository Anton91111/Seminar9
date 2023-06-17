/*Задайте значения M и N. Напишите программу, которая
 выведет все натуральные числа по убыванию в промежутке от M до N  */


using System;
using static System.Console;

WriteLine("Введите натуральное число N:");
int number = int.Parse(ReadLine());
void PrintNumbers (int number)
{
    if (number < 0) Write($"{number} не натуральное число");
    if (number == 0) return;
    Write("{0,4}", number);
    PrintNumbers (number - 1);
}

PrintNumbers(number);