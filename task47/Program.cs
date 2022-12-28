// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] GetRandMatr(int rows, int columns, int leftRange = -10, int rightRange = 10) 
{
    double[,] matrix = new double [rows, columns];

    var rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (double) (rand.Next(leftRange, rightRange + 1))%10/2;
        }
    }
        
    return matrix;
}

void PrintMatr(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int rowsCount = ReadInt("Введите число строк");
int coloumnCount = ReadInt("Введите число столбцов");
double[,] matr = GetRandMatr(rowsCount, coloumnCount);
PrintMatr(matr);
