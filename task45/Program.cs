// Задача 45: Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.

int[] array = {1,2,3,4,5};
int[] newarray = new int[array.Length];
for(int i = 0; i < array.Length; i++)
{
    newarray[i] = array[i];
}
    Console.WriteLine(string.Join(", ", newarray));