
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

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

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.



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





