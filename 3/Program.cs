// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
Console.Clear();
int m = ImputNumbers("Введите число строк 1-й матрицы: ");
int n = ImputNumbers("Введите число столобцов 1-й матрицы (и 2й строки): ");
int l = ImputNumbers("Введите число столобцов 2-й матрицы: ");
int range = ImputNumbers("Введите диапазон случайных чисел: ");

int ImputNumbers(string input)
{
   Console.Write(input);
   int output = Convert.ToInt32(Console.ReadLine()!);
   return output;
}

int[,] oneMatrix = new int[m, n];
CreateArray(oneMatrix);
Console.WriteLine($"\nМатрица №1 :");
WriteArray(oneMatrix);

int[,] twoMatrix = new int[n, l];
CreateArray(twoMatrix);
Console.WriteLine($"\nМатрица №2 :");
WriteArray(twoMatrix);

int[,] resultMatrix = new int[l, m];

multyMatrix(oneMatrix, twoMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение двух матриц");
WriteArray(resultMatrix);


void multyMatrix(int[,] oneMatrix, int[,] twoMatrix, int[,] resultMatrix)
{
   for (int i = 0; i < resultMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < resultMatrix.GetLength(1); j++)
      {
         int sum = 0;
         for (int k = 0; k < oneMatrix.GetLength(1); k++)
         {
            sum += oneMatrix[i, k] * twoMatrix[k, j];
         }
         resultMatrix[i, j] = sum;
      }
   }
}

void CreateArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(range);
      }
   }
}

void WriteArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
   }
}






