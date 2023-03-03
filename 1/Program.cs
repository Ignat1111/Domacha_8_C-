// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] GetArray(int rows, int col, int miniValue, int maxValue)
{
   int[,] result = new int[rows, col];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < col; j++)
      {
         result[i, j] = new Random().Next(miniValue, maxValue);
      }
   }
   return result;
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write($"{array[i, j]}\t");
      }
      Console.WriteLine();
   }
}

void OrderToRosws(int[,] array)
{
   int temp;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int h = 0; h < array.GetLength(1) - 1; h++)
         {
            if (array[i, h] < array[i, h + 1])
            {
               temp = array[i, h + 1];
               array[i, h + 1] = array[i, h];
               array[i, h] = temp;
            }
         }
      }
   }
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine("************");
int[,] sam = GetArray(rows, col, 0, 100);
PrintArray(sam);
Console.WriteLine("*************");
OrderToRosws(sam);
PrintArray(sam);
Console.WriteLine("*************");












