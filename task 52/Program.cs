// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int[,] numbers = new int[4, 4];
MyArray(numbers);
PrintMyArray(numbers);

void MyArray(int[,] array, int leftRange = 0, int rightRange = 9)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
}

void PrintMyArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
// Console.WriteLine(numbers.GetLength(0));
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum += numbers[i, j];
    }
    Console.Write($"{ sum / numbers.GetLength(0)}; ");
}

// Console.WriteLine($"{string.Join(" ", array)}");