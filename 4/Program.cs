// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] GetArray(int x, int y, int z)
{
   int[,,] result = new int[x, y, z];
   int count = 10;
   for (int i = 0; i < x; i++)
   {
      for (int j = 0; j < y; j++)
      {
         for (int k = 0; k < z; k++)
         {
            result[i, j, k] = count++;
         }
      }
   }
   return result;
}

void PrintArray(int[,,] Array)
{
   for (int i = 0; i < Array.GetLength(0); i++)
   {
      for (int j = 0; j < Array.GetLength(1); j++)
      {
         for (int k = 0; k < Array.GetLength(2); k++)
         {
            Console.Write($"{Array[i, j, k]} ({i}, {j}, {k}) \t");
         }
         Console.WriteLine();
      }
      Console.WriteLine();
   }
}


Console.Write("Введите кол - во строк: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол - во колон: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту: ");
int z = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("****************");
if (x * y * z <= 89)
{
   int[,,] eror = GetArray(x, y, z);
   PrintArray(eror);
}
else
{
   System.Console.WriteLine("Ошибка");
}