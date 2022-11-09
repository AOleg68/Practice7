// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

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

void NoNumber(int[,] matrix)
{
    Console.Write("Строка - ");
    int Rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец - ");
    int Colums = Convert.ToInt32(Console.ReadLine());
    if (Rows <= matrix.GetLength(0) && Colums <= matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента {Rows} строки и {Colums} столбца равно {matrix[Rows -1, Colums - 1]}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
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

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
NoNumber(array);



