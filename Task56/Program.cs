// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int[] CreatingArrayElementSums(int[,] matrix)
{
    int[] array = new int [matrix.GetLength(0)];
    int summaElements = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summaElements += matrix[i, j];            
        }
        array[i] = summaElements;
        summaElements = 0;
    }
    return array;
} 

int FindingSmallestSums(int[] arr)
{
    int sumMinLine = arr[0];
    int minLine = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < sumMinLine)
        {
            minLine = i;
            sumMinLine = arr[i];
        }
    }
    return minLine;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

int[] array = CreatingArrayElementSums(array2d);
int result = FindingSmallestSums(array);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}.");
Console.WriteLine("Отсчет начинается с нулевой строки.");