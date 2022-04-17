




// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] MakeRandomArray(int row, int column)
{
    int[,] massive = new int[row, column];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 9);
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
    return massive;
}

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

