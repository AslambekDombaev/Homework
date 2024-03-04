// На основе символов строки (тип данных string)
// сформировать массив символов (тип char[]). 
// Вывести массив на экран


string imput = Console.ReadLine();

char [] Mass_char = new char [imput.Length];

for (int i = 0; i < imput.Length; i++)
{
    Mass_char[i] = imput[i];
}

void PrintChar(char[] Mass_char)
{
    foreach (char i in Mass_char)
    {
        Console.WriteLine(i);
    }
}
PrintChar(Mass_char);


// второе решение
// char[] MassChar(string st)
// {
//     char[] Mass_char = new char[st.Length];
//     for (int i = 0; i < st.Length; i++)
//     {
//         Mass_char[i] = st[i];
//     }
//     return Mass_char;
// }

// void PrintChar(char[] Mass_char)
// {
//     foreach (char i in Mass_char)
//     {
//         Console.WriteLine(i);
//     }
// }


// string imput = Console.ReadLine()!;
// char[] mass_char_new = MassChar(imput);
// PrintChar(mass_char_new);



int CountVowels (string st)
{
    int s = 0;
    string vowels = "aoueiAOUEI";
    for (int i = 0; i < st.Length; i++)
    {
        foreach (var j in vowels)
        {
            if (st[i] == j)
            {
                s++;
            }
        }
    }
    return s;
}

bool CheckIfLetter (string st)
{
    for (int i = 0; i < st.Length; i++)
    {
        if (!(char.IsLetter(st[i]) || st[i] == ' '))
        {
            return false;
        }
            
    }
    return true;
}

string st = Console.ReadLine()!;
if (CheckIfLetter(st))
{
    int vowels = CountVowels(st);
    Console.WriteLine(vowels);
}
else
{
    Console.WriteLine("Введен неверный формат");
}