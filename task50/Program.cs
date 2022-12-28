// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Введите номер позиции строки: ");
int colums = ReadInt("Введите номер позиции столбца: ");
Console.WriteLine("Массив");
int[,] numbers = new int[6, 7];
MyArray(numbers);
PrintMyArray(numbers);


if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine("Значение элемента =" + numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums}-> такого числа в массиве нет");

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
