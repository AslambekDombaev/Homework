// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Numbers (int m, int n)
{
    if(m > n)
    {
        return;
    }
    
    Numbers(m, n - 1);
    System.Console.WriteLine($"{n} ");
}



Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Numbers(m, n);