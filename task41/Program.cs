// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите число, закончите ввод словом stop:");

int number = 0;
int count = 0;
string s = string.Empty;

do
{
    s = Console.ReadLine();
    if (s == "stop")
    {
        break;
    }
    else 
    {number = Convert.ToInt32(s);
    if (number > 0) 
        {
            count +=1;
        }
    }
}
while (true);
Console.WriteLine($"Положительных чисел введено {count}");