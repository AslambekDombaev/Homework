
int[] array = new int[8];
int b = 0;
for (int i = 0; i < array.Length; i++)
{
    Random rnd = new Random();
    array[i] = rnd.Next(100, 1000);
    if(array[i] % 2 == 0)
    {
        b = b + 1;
    }
    Console.Write($"{array[i]} ");
}

Console.WriteLine(b);
