// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],4}    ");
//         System.Console.WriteLine();
//     }
// }

// void SortToLowerArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("ВВедите количество строк");
// int crow = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов");
// int cols = int.Parse(Console.ReadLine()!);
// int[,] array = new int[crow, cols];
// FillArray(array);
// PrintArray(array);
// SortToLowerArray(array);
// PrintArray(array);





// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// void SumsRowMin(int[,] array)
// {
//     int MinRow = 0;
//     int MinSumRow = 0;
//     int SumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         MinRow = MinRow + array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             SumRow = SumRow + array[i, j];
//         if (SumRow < MinRow)
//         {
//             MinRow = SumRow;
//             MinSumRow = i;
//         }
//         SumRow = 0;
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumRow + 1} ");
// }

// Console.WriteLine("ВВедите количество строк");
// int crow = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов");
// int cols = int.Parse(Console.ReadLine()!);
// int[,] array = new int[crow, cols];
// FillArray(array);
// PrintArray(array);
// SumsRowMin(array);


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("ВВедите количество строк");
// int crow = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов");
// int cols = int.Parse(Console.ReadLine()!);
// int[,] array = new int[crow, cols];
// int[,] secondArray = new int[crow, cols];
// int[,] resultArray = new int[crow, cols];

// FillArrayRandom(array);
// PrintArray2D(array);

// Console.WriteLine();

// FillArrayRandom(secondArray);
// PrintArray2D(secondArray);

// Console.WriteLine();

// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }

// PrintArray2D(resultArray);