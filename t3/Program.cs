/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


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

int[] array = Arr(10, 11, 21);
int max = 0; 
int min = array[0];

int Sub(int[] array) {
    foreach (int i in array)
        {
            if (i>max) max = i;
            if (i<min) min = i;
        }
    int subtraction = max - min;
    return subtraction;
}
int ff = Sub(array);
Console.WriteLine();
Console.WriteLine($"разницa между максимальным и минимальным элементов массива = {ff}");