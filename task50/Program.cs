// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
// элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 1(строчка) 7 (столбец) -> такого числа в массиве нет
Console.WriteLine("Введите позиции элемента через Enter: ");
int firstPosition = Convert.ToInt32(Console.ReadLine());
int secondPosition = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
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

int[,] resultMatrix = GetMatrix(3, 4);
PrintMatrix(resultMatrix);

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    if (firstPosition == i)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (secondPosition == j)
            {
                Console.WriteLine(resultMatrix[i, j]);
            }
        }
    }
}

