// Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

void Reverse(int [] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
const int LENGTH = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 10;
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");
Console.WriteLine();
Reverse(massive);
Console.WriteLine($"[{string.Join(", ", massive)}]");