// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
int C = ReadInt("Введите число C: ");
if(A < B + C && B < A + C && C < A + B)
{
    Console.WriteLine("Может");
}
else
{
    Console.WriteLine("Не может");
}