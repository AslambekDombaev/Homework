// for (float i = 200; i > 10; i /= 2)
//     Console.WriteLine("Elemet: {0}", i);

// byte i = 10;
// while (i >= 1)
// {
//     Console.WriteLine("Elemet: {0}", i);
//     i--;
// }

// bool isHasCar = true;
// while(isHasCar) {
//     string end = Console.ReadLine();
//     if(end == "end")
//     isHasCar = false;
// }


// byte i = 100;

// do {
// Console.WriteLine("Elemet: " + i);
// } while(i < 10);



// for (short i = 0; i < 10; i++) {
//     if(i > 5)
//     break;

//     Console.WriteLine("Elemet: " + i);
// }


for (short i = 0; i < 10; i++) {
    if(i % 2 == 0)
    continue;

    Console.WriteLine("Elemet: " + i);
}