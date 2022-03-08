using System;

// Задача 1
/*
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
*/


// задача 2

Console.WriteLine("Введите первое целое число из трёх");
int numb1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое число из трёх");
    int numb2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье целое число из трёх");
        int numb3 = Convert.ToInt32(Console.ReadLine());

    
if(numb1 > numb2 && numb1 > numb3)
    {
        Console.WriteLine("max = " + numb1);
    }
else
    {
        if(numb2 > numb3)
        {
            Console.WriteLine("MaX = " + numb2);
        }
        else
        {
            Console.WriteLine("MAX = " + numb3);
        }    
    }





   



    


    




