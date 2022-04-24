

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void MakeDoubleArray(int row, int column)
{
    double [,] array = new double[row, column];

    for (int i = 0; i < row; i++)
    {
            for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * 10; // Как задать отрицательные значения не понял.
            Console.Write(array[i, j].ToString ("0.0") + " ");
        }
            Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

MakeDoubleArray(m, n);
*/





// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


/*
int[,] MakeRandomArray(int row, int column)
{
    int[,] massive = new int[row, column];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 99);
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
    return massive;
}

void FindPositionInArray(int[,] matrix_array, int a, int b)
{
    for (int i = 0; i < matrix_array.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_array.GetLength(1); j++)
        {
            if (i == a - 1 && j == b - 1)
            {
                Console.WriteLine($"Элемент в строке {a} и столбце {b} = {matrix_array[i, j]}");
            }

        }

    }
    if (a > matrix_array.GetLength(0) || b > matrix_array.GetLength(1))
    {
        Console.WriteLine($"Элемента в строке {a} и столбце {b} в массиве нет");
    }
}

Console.WriteLine("Задайте количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] working_array = MakeRandomArray(m, n);

Console.WriteLine("Задайте строку искомого элемента в массиве ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте столбец искомого элемента в массиве ");
int y = Convert.ToInt32(Console.ReadLine());

FindPositionInArray(working_array, x, y);

*/




// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] MakeRandomArray(int row, int column)
{
    int[,] massive = new int[row, column];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(10, 99);
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
    return massive;
}
/*
void ColumnSum(int[,] colsum_array)
{
    for (int j = 0; j < colsum_array.GetLength(1); j++)
    {
        double colsumma = 0;
        double result = 1;
        for (int i = 0; i < colsum_array.GetLength(0); i++)
        {
            colsumma = colsumma + colsum_array[i, j];
        }
        result = colsumma / colsum_array.GetLength(0);
        Console.Write(string.Format("{0:0.0}", result) + " ");
    }
}

Console.WriteLine("Задайте количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] working_array = MakeRandomArray(m,n);
ColumnSum(working_array);
*/



// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void SumRow(int[,] rowsumma_array)
{
    int minrowsumma = 1000000;
    int minrow = 0;

    for (int i = 0; i < rowsumma_array.GetLength(0); i++)
    {
        int rowsum = 0;

        for (int j = 0; j < rowsumma_array.GetLength(1); j++)
        {
            rowsum = rowsum + rowsumma_array[i, j];

        }
        Console.WriteLine($"RS = {rowsum} i = {i}");
          if (minrowsumma > rowsum)
          {
              minrowsumma = rowsum;
              minrow = i;
          }

    }
    Console.Write($"Строка {minrow} и сумма = {minrowsumma}");
}


Console.WriteLine("Задайте количество строк в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] working_array = MakeRandomArray(m, n);  // MakeRandomArray создан выше 94-106
SumRow(working_array);

// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// Задача 4: Заполните спирально массив 4 на 4.