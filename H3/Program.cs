// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] firstarray = new int [4,4];
int [,] secondarray = new int [4,4];

for (int i = 0; i < firstarray.GetLength(0); i++)
{
    for (int j = 0; j < firstarray.GetLength(1); j++)
    {
        firstarray[i,j] = new Random().Next(0,10);
        Console.Write(firstarray[i,j] +" ");
    }
    Console.WriteLine();
}
Console.WriteLine("_______________");

for (int i = 0; i < secondarray.GetLength(0); i++)
{
    for (int j = 0; j < secondarray.GetLength(1); j++)
    {
        secondarray[i,j] = new Random().Next(0,10);
        Console.Write(secondarray[i,j] +" ");
    }
    Console.WriteLine();
}
Console.WriteLine("_______________");


int[,] thirdarray = new int[4,4];
for (int i = 0; i < thirdarray.GetLength(0); i++)
{
    for (int j = 0; j < thirdarray.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < firstarray.GetLength(1); k++)
        {
            sum+=firstarray[i,k]*secondarray[k,j];
        }
    Console.Write((thirdarray[i,j]=sum)+" ");
    }
    Console.WriteLine();
}