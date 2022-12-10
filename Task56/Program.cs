// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой  элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(row, col, -10, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] sumArray = SumArray(matrix, row, col);
PrintArray(sumArray, row);
MinOfSum(sumArray);

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

int[] SumArray(int[,] matrix, int row, int col)
{
    int[] sumArray = new int[row];
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum += matrix[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void PrintArray(int[] array, int row)
{
    for (int i = 0; i < row; i++)
    {
        if (i == row - 1)
        {
            Console.WriteLine($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

void MinOfSum(int[] array)
{
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < array[maxIndex])
            {
                maxIndex = j;
            }
        }
    }
    System.Console.WriteLine($"The minimum summ is in row {maxIndex + 1}");
}