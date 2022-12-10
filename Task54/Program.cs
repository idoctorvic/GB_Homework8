// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(row, col, -10, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(Sort(matrix, row, col));

int[,] FillMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int[] array = new int[] { 5, 7, 2, 3, 9 };
// int[] arr = array.OrderByDescending(a => a).ToArray();
// Print(arr);
// void Print(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item}, ");
//     }
// }

int[,] Sort(int[,] matrix, int row, int col)
{
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            int maxIndex = j;
            for (int k = j + 1; k < col; k++)
            {
                if (matrix[i, k] > matrix[i, maxIndex])
                {
                    maxIndex = k;
                }
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, maxIndex];
            matrix[i, maxIndex] = temporary;

        }
    }
    return matrix;
}

