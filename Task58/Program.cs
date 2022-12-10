// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Enter amount of rows in the 1st table: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns in the 1st table: ");
int col1 = Convert.ToInt32(Console.ReadLine());
int row2 = col1;
Console.WriteLine($"The amount of rows in the 2nd table must be equal to the amount of columns in the 1st table - {row2} rows");
Console.Write("Enter amount of columns in the 2nd table: ");
int col2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = FillMatrix(row1, col1, -10, 10);
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = FillMatrix(row2, col2, -10, 10);
PrintMatrix(matrix2);
System.Console.WriteLine();
PrintMatrix(MatrixMult(matrix1, matrix2, row1, col1, col2));

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

int[,] MatrixMult(int[,] mat1, int[,] mat2, int row, int col1, int col2)
{
    int[,] newMatrix = new int[row, col2];
    for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    for (int k = 0; k < col1; k++)
                    {
                        newMatrix[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            return newMatrix;
}