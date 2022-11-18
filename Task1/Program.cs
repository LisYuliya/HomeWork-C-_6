/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int count = 0;
int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = int.Parse(Console.ReadLine()!);
}

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        count++;
    }
    
}

string s = string.Join(", ", array);
Console.WriteLine($"[{s}] -> чисел больше 0: {count}");


