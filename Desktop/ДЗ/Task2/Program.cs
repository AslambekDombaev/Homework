﻿// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void Counts(int m, int n)
{
    if (n < m)
    {
        return;
    }   
    
    Counts(m, n-1);
    Console.Write($"{n} "); 
}


Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Counts(m , n);