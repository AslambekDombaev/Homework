// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N.

// void PrintNum (int num)
// {
//     if (num < 1)
//     {
//         return;
//     }
//     Console.Write($"{num} ");
//     PrintNum(num - 1);
// }
Console.WriteLine("Введите число равное M: ");
int m = Convert.ToInt32(Console.ReadLine());
//PrintNum(n);

string PrintNum(int n, int m)
{
    if (n == m)
    {
        return Convert.ToString(n);
    }
return n + " " + PrintNum(n + 1, m);
}
Console.WriteLine(PrintNum(1, m));