// byte[] nums = new byte[5];
// nums[0] = 250;
// nums[1] = 50;
// nums[2] = 20;
// nums[3] = 100;
// nums[4] = 25;

// // System.Console.WriteLine("El: " + nums[0]);

// string[] words = new string[] {"John", "Bob", "Alex"};
// words[1] = "Bich";
// for (byte i = 0; i < words.Length; i++)

// System.Console.WriteLine("El: " + words[i]);


// short[] numbers = new short[10];
// short sum = 0;
// Random random = new Random();

// for (byte i = 0; i < numbers.Length; i++)
// { 
//     numbers[i] = Convert.ToInt16(random.Next(-15, 15));
//     Console.WriteLine("El: " + numbers[i]);

//     sum += numbers[i];

// }
// Console.WriteLine("Summa: " + sum);



char[,] symbols = new char[2, 3];
symbols[0, 0] = 'H';
System.Console.WriteLine(symbols[0, 0]);

int[,] nums = {
    {4, 6, 7},
    {5, 7, 3},
    {3, 3, 2}
};
nums[1, 2] = 56;
