// Задача 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int cols, int rows)
{
    int[,] matrix = new int[cols, rows];
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            matrix[i, j] = new Random().Next(1001);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int sizeMatrixCols = 3;
int sizeMatrixRows = 4;
int[,] resultMatrix = GetMatrix(sizeMatrixCols, sizeMatrixRows);
PrintMatrix(resultMatrix);

System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
int average = 0;
for (int j = 0; j < sizeMatrixRows; j++)
{
    for (int i = 0; i < sizeMatrixCols; i++)
    {
        average += resultMatrix[i, j];
        if (i == sizeMatrixCols - 1)
        {
            average /= sizeMatrixCols;
            Console.Write($"{average} ");
            average=0;
        }
    }
}