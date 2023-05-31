// Задача 47. 

// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// double[,] array2d = new double[3,4];


// for (int i=0; i < array2d.GetLength(0); i++)
// {
//     for (int j=0; j < array2d.GetLength(1); j++)
//     {
//         array2d[i,j] = new Random().Next(-99,99) / 10.0;
//         Console.Write(array2d[i,j] + "; ");
//     }
//     Console.WriteLine();
// }



/////////////////////////////////////////////////////////////////////////////

// Задача 50. 

// Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// int[,] array2d = new int[3,4];


// for (int i=0; i < array2d.GetLength(0); i++)
// {
//     for (int j=0; j < array2d.GetLength(1); j++)
//     {
//         array2d[i,j] = new Random().Next(1,10);
//         Console.Write(array2d[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите позицию строки: ");
// int line = Convert.ToInt32(Console.ReadLine()) -1;
// Console.Write("Введите позицию столбца: ");
// int column = Convert.ToInt32(Console.ReadLine()) -1;
// if (line < 0 || column < 0)
// Console.Write("Позиции не могут быть отрицательными");
// else if (line <= array2d.GetLength(0) && column <= array2d.GetLength(1))
// Console.Write($"Значение элемента {array2d[line, column]}");
// else 
// Console.Write("Такого элемента нет в массиве ");



////////////////////////////////////////////////////////////////////


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2d = new int[3,4];

for (int i=0; i < array2d.GetLength(0); i++)
{
    for (int j=0; j < array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(1,10);
        Console.Write(array2d[i,j] + " ");
    }
    Console.WriteLine();
}



Console.Write("Среднее арифметическое каждого столбца; ");
for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum = sum + array2d[i, j];
    }
    Console.Write($"{ sum / array2d.GetLength(0):F1} ");
    
}
Console.WriteLine();







