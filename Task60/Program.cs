// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndIntOriginal(int rows, int columns, int page)
{
    int[,,] matrix = new int[rows, columns, page];
    int[] array = new int[rows * columns * page];
    Random rnd = new Random();
    int n = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int z = 1;
                while (z == 1)
                {
                    z = 0;
                    matrix[i, j, k] = rnd.Next(10, 99);
                    array[n] = matrix[i, j, k];
                    for (int m = 0; m < n; m++)
                    {
                        if (array[m] == array[n]) z = 1;
                    }
                }
                n++;
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3}({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3d = CreateMatrixRndIntOriginal(2, 2, 2);
PrintMatrix(array3d);


