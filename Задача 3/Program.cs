// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 15);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void AverageNumberByColums(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        double Summa = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            Summa += matrix [i,j];
        }
        Console.WriteLine($"Cреднее арифметическое элементов в {j+1} столбце равно =  {Summa / matrix.GetLength(0)}; ");
    }
}



int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
AverageNumberByColums(array);

