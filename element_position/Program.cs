// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет


int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols]; 
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix; 
}
void PrintMatrix(int[,] matr) 
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


Console.WriteLine("Введите  номер  строки:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  номер  столбца");
int n = Convert.ToInt32(Console.ReadLine());
int[,] resultMatrix = GetMatrix(6, 6, -100, 100);

if (m >= resultMatrix.GetLength(0) || n >= resultMatrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно: {resultMatrix[m, n]}");
}
Console.WriteLine();
Console.WriteLine("Матрица:");
PrintMatrix(resultMatrix);