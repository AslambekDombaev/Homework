
using System.Runtime.InteropServices;

Console.WriteLine("Enter name: ");
string role = Console.ReadLine()!;

if(role == "Admin") {
Console.Write("Enter user name: ");
string user_name = Console.ReadLine()!;
Console.Write("Enter {0} age: ", user_name);
short age = Convert.ToInt16(Console.ReadLine());

if(age <= 0 || age > 99){
Console.Write("Enter {0} age: ", user_name);
age = Convert.ToInt16(Console.ReadLine());
}

if(age <= 0 || age > 99) {
   Console.WriteLine("Error");
    age = 10;
}
   else
   Console.WriteLine("Users age is " + age);
} else
    Console.WriteLine("You are not admin!");
