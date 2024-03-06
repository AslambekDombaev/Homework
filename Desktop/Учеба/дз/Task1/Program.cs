// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


string CharsIndex (char[,] arr)
{
    string st = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            st += arr[i, j];
        }
    }
    return st;
}



char[,] chars = new char[,]{{'a', 'b', 'c'}, {'d', 'e', 'f'}};

Console.WriteLine(CharsIndex(chars));
