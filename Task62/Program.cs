// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] SpiralFillingMatrix(int x)
{
    int[,] array2d = new int[x, x];
    int number = 1;
    int row = 0;
    int col = -1;
    int diminutive = 1;
    
    for (int e = 0; e < x; e++) array2d[row, ++col] = number++;
    for (int g = 0; g <= x*x; g++)
    {
        for (int i = 0; i < x - diminutive; i++) array2d[++row, col] = number++;
        for (int i = 0; i < x - diminutive; i++) array2d[row, --col] = number++;
        diminutive++; 

        for (int i = 0; i < x - diminutive; i++) array2d[--row, col] = number++;
        for (int i = 0; i < x - diminutive; i++) array2d[row, ++col] = number++;      
        diminutive++; 
    }    
    return array2d;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int numberRowsColumns = 4;
int[,] matrix = SpiralFillingMatrix(numberRowsColumns);

PrintMatrix(matrix);
