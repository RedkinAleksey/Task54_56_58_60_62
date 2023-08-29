// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine();
    }
}

void ArrangeDescendingRowElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j + 1] > matrix[i, j])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = temp;
                ArrangeDescendingRowElements(matrix);
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2d);
Console.WriteLine();
ArrangeDescendingRowElements(array2d);
Console.WriteLine("Массив с элементами, в строках упорядоченными по убыванию:");
PrintMatrix(array2d);





