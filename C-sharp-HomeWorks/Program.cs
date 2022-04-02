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
/*
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

*/

  // Задача 13 (получилось криво, не знаю как уйти от части после запятой).

/*
 double num = 6472515;
 double i = 1;
 double a;
 double b = num;
 double c;

 while(b > 0)
{
    c = Math.Pow (10,i);
    a = num % c;
    b = num - a;
  
    i++;
}
  
   double ber = num % Math.Pow(10,(i-3)) / Math.Pow(10,(i-4));
 int bear = Convert.ToInt32(ber);
  Console.WriteLine(bear);

*/  


  // Задача 15
 /*   
    void FindWeekend(int num)
{
    if(num >= 6 && num <= 7)
    {
        Console.WriteLine("Введенное число соответствует выходному дню недели :)");
    }
    else
    {
        Console.WriteLine("Увы, это рабочий день :( ");
    }
}  

Console.WriteLine("Введите число обозначающее день недели");
int day = Convert.ToInt32(Console.ReadLine());

    if(day > 7)
    {
        Console.WriteLine("Ошибка, в неделе 7 дней. Попробуйте еще раз");

    }
    else
    {
        FindWeekend(day);
    }

 */


    // Задача 19

    /*

    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
 
    int a = (number % 10 - number % 1) / 1;
   // Console.WriteLine("5 numb = " + a);

    int b = (number % 100 - number % 10) / 10;
   // Console.WriteLine("4 numb = " + b);

    int c = (number % 10000 - number % 1000) / 1000;
   // Console.WriteLine("2 numb = " + c);

    int d = (number % 100000 - number % 10000) / 10000;
   // Console.WriteLine("1 numb = " + d);

    
    if ( a == d && b == c)
        {
            Console.WriteLine("Число является палиндромом");
        }

        else 
        {
            Console.WriteLine("oh NO");
        }    
*/


// попытка создать массив из цифр составляющих число из задачи 19. Орфографии не хватает

  /* while (i < 100000)
{
        int numb(i) = (number % (10*i) - number % i) / i;
        Console.WriteLine( i + " numb = " + numb(i));

        i = i * 10;
}
*/
    
 

    // Задача 21

 /*   double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)

    {
        double xDistance = x2 - x1;
        double yDistance = y2 - y1;
        double zDistance = z2 - z1;
        

          //  Console.WriteLine("x dis = " + xDistance); для проверки
          //  Console.WriteLine("y dis = " + yDistance);
          //  Console.WriteLine("z dis = " + zDistance);

        
        double result = Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2));
        return result;

    }

    double xA, yA, zA, xB, yB, zB;

    Console.WriteLine("Введите данные точки А - Х");
        xA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите данные точки А - Y");
        yA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите данные точки A - Z");
        zA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите данные точки B - X");
        xB = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите данные точки B - Y");
        yB = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите данные точки B - Z");
        zB = Convert.ToDouble(Console.ReadLine());

        

    Console.WriteLine(GetDistance(xA, yA, zA, xB, yB, zB));

 */   

  // Задача 23 
  
 /*

Console.WriteLine("Введите целое число");
int value = Convert.ToInt32(Console.ReadLine());

int numb_ch = 1;
 
while(numb_ch <= value)
{
    Console.Write(Math.Pow(numb_ch, 3) + " ");
    numb_ch++;
} 

*/

    
    // Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


/*
    int mathDegree(int value1, int value2)
    {
        int result = 1;
        for(int i = 0; i < value2; i++)
        {
        result = result * value1; 
        }           
        return result;    
    }


Console.WriteLine("Введите первое целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if ( numberA >= 0 && numberB >= 0)
{
    Console.WriteLine("Число " + numberA + " возведенное в степень " + numberB + " равно " + mathDegree(numberA, numberB));
}
else Console.WriteLine("Ошибка, необходимо ввести натуральные числа");

*/


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SummaNums(int value)
{
    int result = 0;
    for(int i = 1; value >= 1; i++)
    {
        int remain = value % 10;
        value = (value - remain) / 10;
        result = result + remain;
    }
    return result;
}

Console.WriteLine("Введите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA < 0)
{ 
    numberA = Math.Abs(numberA);
    Console.WriteLine("Сумма цифр, составляющих число -" + numberA + ", равна " + SummaNums(numberA));
}

else

    Console.WriteLine("Сумма цифр, составляющих число " + numberA + ", равна " + SummaNums(numberA));








    




