// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of tubes: ");
int tube = Convert.ToInt32(Console.ReadLine());
int length = row * col * tube;

int[] array = FillArray(length);
Print(array);
System.Console.WriteLine();
int[] sortedArray = SortArray(array);
Print(sortedArray);
System.Console.WriteLine();
int[,,] matrix = MakeMatrix(sortedArray);
PrintMatrix(matrix);

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

int[] SortArray(int[] array)
{

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
            {
                array[i] = new Random().Next(10, 100);
            }
        }

    }
    return array;
}

void Print(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

int[,,] MakeMatrix(int[] array)
{
    int[,,] matrix = new int[row, col, tube];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = array[index];
                index ++;
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
                Console.Write($"{matrix[i, j, k]}{(i, j, k)} ");
            }

        }
        Console.WriteLine();
    }
}

