void InputArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-20, 21); // [-20; 20]
}

int[] sortVibor (int[] array)
{
for (var i = 0; i < array.Length - 1; i++) // Счётчики цикла лучше всего обзывать i, j, k, m, n
{
int indexMin = i;
for (var j = i + 1; j < array.Length; j++)
{
if(array[j] < array[indexMin])
indexMin = j;
}
int temp = array[i];
array[i] = array[indexMin];
array[indexMin] = temp;
}
return array;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
// Для начала выведем на экран сгенерированные элементы
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", sortVibor(array))}]");