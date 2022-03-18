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
/*
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
*/

// Задача 3

/*
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Введенное число является чётным. Ура!");

}
else
{
    Console.WriteLine("Введенно нечётное число. :(");
}
*/

// Задача 4

/*
Console.WriteLine("Введите целое число");
int value = Convert.ToInt32(Console.ReadLine());
int numb_ch = 2;

if(value <= 1)
{
    Console.WriteLine("Ошибка, Введите другое число");
} 
else

while(numb_ch <= value)
{
    Console.Write(numb_ch + " ");
    numb_ch+=2;
}

*/


 // Задача 10

    int FindSecondNumber(int num)
    {
        int n1 = num / 100;
        int n2 = num - n1*100;
        int n3 = n2 / 10;

        return n3;
    }
    
Console.WriteLine("Введите целое трехзначное число");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая цифра равняется = " + FindSecondNumber(value));


  // Задача 23

/*
Console.WriteLine("Введите целое число");
int value = Convert.ToInt32(Console.ReadLine());

int numb_ch = 1;
 
while(numb_ch <= value)
{
    Console.Write(numb_ch*numb_ch*numb_ch + " ");
    numb_ch++;
} 

*/

    


    




