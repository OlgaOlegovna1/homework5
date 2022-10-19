﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19             

[-4, -6, 89, 6] -> 0*/


int[] Arr(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = Arr(10, -10, 77);
Console.WriteLine();
int even = 0;
int odd = 0;
int i = 0;
int sum = 0;
foreach (int y in array)
{
   
   if ((i % 2)!=0) sum = sum + y;
   i++; 
}
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {sum}");