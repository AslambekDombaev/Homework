
int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    } 
        else 
        
            if(m > 0 && n == 0)
            {
            return Akkerman(m - 1, 1);
            }
        
            else 
            {
                    return Akkerman(m - 1, Akkerman(m, n - 1));
            }       
}



System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Result = Akkerman(m, n);
System.Console.WriteLine(Result);

