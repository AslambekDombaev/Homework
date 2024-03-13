// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


void SumNum(int [] Mas, int i = 0)
{
    if (i == Mas.Length) 
    return;

SumNum(Mas, i + 1);
System.Console.Write($"{Mas[i]} ");
}

int[] Mas = new int[] {1, 2, 3, 4, 5};
SumNum(Mas);


// int[] FillArrayRandomly(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// void RecursiveArrayPrint (int [] arr, int index = 0)
// {
//     if (index == arr.Length)
//     { 
//     return;
//     }
//     RecursiveArrayPrint(arr, index + 1);
//     Console.Write($"{arr[index]} ");
  
// }

// void PrintArray(int[] arr)
// {
//     foreach (var item in arr)
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int [] array = FillArrayRandomly(m);
// PrintArray(array);
// RecursiveArrayPrint(array);

