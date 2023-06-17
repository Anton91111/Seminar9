/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. 
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;

WriteLine("Введите  число M:");
int M = int.Parse(ReadLine());

WriteLine("Введите число M:");
int N = int.Parse(ReadLine());

void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

GapNumberSum(M, N, 0);