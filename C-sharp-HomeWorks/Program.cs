using System;

// Задача 1

Console.WriteLine("Введите первое число");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numb2 = Convert.ToInt32(Console.ReadLine());

if(numb2 > numb1)
{
    Console.Write("Большее число ");
    Console.WriteLine(numb2);
    Console.Write("Меньшее число ");
    Console.WriteLine(numb1);
    
}
    

else

Console.Write("Большее число " + numb1 + " " + "Меньшее число " + numb2);



