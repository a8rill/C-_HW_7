// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность массива m x n");
	int m=int.Parse(Console.ReadLine());
	int n=int.Parse(Console.ReadLine());
	int[,] array = new int[m,n];
	Console.WriteLine($"{m} x {n}");
	
    for(int i=0;i<m;i++)
	 for(int j=0;j<n;j++)
	 {
		 array[i,j] = new Random().Next(0, 10);
	 }
	
	Console.WriteLine("Вывод элементов массива");
	for(int i=0;i<m;i++)
	 {
	 for(int j=0;j<n;j++)
	    Console.Write($"{array[i,j]} ");
	 Console.WriteLine();	
	 }	
	
	double[] ave = new double[n];
	for(int j=0;j<n;j++)
	{
	 int sum=0;
	 for(int i=0;i<m;i++)
	  	sum=sum+array[i,j];
	 ave[j]=(double)sum/(double)m;
	} 
	Console.WriteLine($"Среднее арифметическое каждого столбца: [{String.Join("; ", ave)}]");