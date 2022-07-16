// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

/*
Random rand = new Random();
double[,] array = new double[4, 5];

for (int i = 0; i < array.GetLength(0); i ++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.NextDouble() * 10 - 5;
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
*/

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

    double[,] array = new double[4, 5];
    int row;
    int column;
    FillArrayDouble(array);
    PrintArrayDouble(array);

    Console.WriteLine("Введите номер интересующей строки");
    row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер интересующего столбца");
    column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (row < array.GetLength(0) && column < array.GetLength(1))
    {
        Console.WriteLine("Искомый элемент" + array[row, column]);
    }
*/


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    double[,] array = new double[4, 5];
    // FillArrayDouble(array);
    // PrintArrayDouble(array);

    for (int j =0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        sum /= array.GetLength(0);
        Console.WriteLine($"Для {j+1} столбца среднее арифметическое равно " + Math.Round(sum, 2));
        Console.WriteLine();
    }


