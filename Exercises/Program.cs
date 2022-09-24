/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = new double[m,n];
for (int i = 0; i < myArray.GetLength(0); i++) 
  {
    for (int j = 0; j < myArray.GetLength(1); j++) 
    {
      myArray[i, j] = new Random().Next(-10,10);
      Console.Write(myArray[i,j] + "\t");
    }
    Console.WriteLine();
  } 

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[4,5];
for (int i = 0; i < newArray.GetLength(0); i++) 
  {
    for (int j = 0; j < newArray.GetLength(1); j++) 
    {
      newArray[i, j] = new Random().Next(21);
      Console.Write(newArray[i,j] + "\t");
    }
    Console.WriteLine();
  } 
if (m > newArray.GetLength(0) || n > newArray.GetLength(1))
{
  Console.WriteLine("такого элемента в массиве нет");
}
else Console.WriteLine($"значение элемента {m} строки и {n} столбца соответствует элементу {newArray[m-1,n-1]}");

/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] newArray = new int[3,3];
for (int i = 0; i < newArray.GetLength(0); i++) 
  {
    for (int k = 0; k < newArray.GetLength(1); k++) 
    {
      newArray[i, k] = new Random().Next(11);
      Console.Write(newArray[i,k] + "\t");
    }
    Console.WriteLine();
  } 
Console.WriteLine();
for (int k = 0; k < newArray.GetLength(1); k++) 
{
  double avSum = 0;
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    avSum += newArray[i,k];
  }
  Console.WriteLine(Math.Round(avSum/newArray.GetLength(1), 2));  
}
