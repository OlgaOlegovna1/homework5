/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Write("Введите элементы(через пробел): ");
string strConsole = Console.ReadLine(); //получаем введенное в строку
string[] strArr = strConsole.Split(' '); //переводим строку в строковый массив
int[] arr = Array.ConvertAll(strArr, int.Parse); //переводим строковый массив в цифровой массив

void PrintArray(int[] someArr)
{
    int count = 0;

    for (int i = 0; i < someArr.Length; i++)
        {
            if (someArr[i] > 0)
                {
                    count++;
                }
        }
        Console.WriteLine($"Кол-во элементов > 0: {count}");
} 

PrintArray(arr); //вызов метода с передачей откуда брать данные