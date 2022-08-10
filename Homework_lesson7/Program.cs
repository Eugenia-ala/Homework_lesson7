// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

void Zadacha47()
{
    double[,] array = new double[4,5];

    FillArrayDouble(array);
    PrintArrayDouble(array);
}
void FillArrayDouble(double[,] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for(int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = Math.Round(rand.NextDouble() * 10 - 5, 2);
        }
    }
}

void PrintArrayDouble(double[,] currentArray)
{
        for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for(int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Zadacha47


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 
void Zadacha50()
 {
    double[,] array = new double[4,5];
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
        Console.WriteLine("Искомый элемент " + array[row-1, column-1]);
    }
    else 
    {
        Console.WriteLine("Искомый элемент не найден");
    }
 }
// Zadacha50();

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    double[,] array = new double[4, 5];
    FillArrayDouble(array);
    PrintArrayDouble(array);

    for (int j = 0; j < array.GetLength(1); j++)
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
}
Zadacha52();
