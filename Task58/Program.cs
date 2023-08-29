// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

            Console.Write($"{matrix[i, j],7}");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i,j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] = result[i, j] + matrix2[k, j] * matrix1[i, k];
            }
        }
    }
    return result;
}

int rowsFirstMatrix = 0;
int columnsFirstMatrix = 0;
int rowsSecondMatrix = 0;
int columnsSecondMatrix = 0;

while (rowsFirstMatrix <= 0 || columnsFirstMatrix <= 0
|| rowsSecondMatrix <= 0 || columnsSecondMatrix <= 0)
{
    Console.Clear();
    Console.WriteLine("Количество строк и столбцов в матрицах должно быть больше нуля.");
    Console.WriteLine("Введите количество строк первой матрицы.");
    rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов первой матрицы.");
    columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк первой матрицы.");
    rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк первой матрицы.");
    columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());
}

int[,] matrixNumber1 = CreateMatrixRndInt(rowsFirstMatrix, columnsFirstMatrix, 1, 4);
int[,] matrixNumber2 = CreateMatrixRndInt(rowsSecondMatrix, columnsSecondMatrix, 1, 4);
PrintMatrix(matrixNumber1);
Console.WriteLine();
PrintMatrix(matrixNumber2);
Console.WriteLine();

if (columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Матрицы умножить невозможно.");
}
else
{
    int[,] resultMatrix = MatrixMultiplication(matrixNumber1, matrixNumber2);
    PrintMatrix(resultMatrix);
}