//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной
//диагонали(с индексами (0,0); (1, 1))и тд

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(11);
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
int sum = 0;

if (sizeMatrixRows >= sizeMatrixCols)
{
    for (int i = 0, j = 0; i < sizeMatrixCols; i++, j++)
    {
        sum += resultMatrix[i, j];
    }
}
else
{
    for (int i = 0, j = 0; j < sizeMatrixRows; i++, j++)
    {
        sum += resultMatrix[i, j];
    }
}
Console.WriteLine(sum);