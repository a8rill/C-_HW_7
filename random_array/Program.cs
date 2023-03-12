﻿// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность массива m x n");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double[,] array = GetMatrix(m,n);

double [,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols]; 
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return matrix; 
}

void PrintMatrix(double[,] matr) 
{
for (int i = 0; i < matr.GetLength(0); i++) 
{
for (int m = 0; m < matr.GetLength(1); m++) 
{
Console.Write(matr[i, m] + "\t"); 
}
Console.WriteLine();
}
}
Console.WriteLine("Массив:");
PrintMatrix(array);