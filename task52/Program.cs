
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = new int[4,3];

int[,] fillArray(int [,] arrayForFill)
{
    for(int i = 0; i < arrayForFill.GetLength(0); i++)
    {
        for(int j = 0; j < arrayForFill.GetLength(1); j++)
        {
            arrayForFill[i,j] = Random.Shared.Next(0,10);
        }
    }
    return arrayForFill;

}

double [] averageColumn(int [,] array1)
{
    double [] averageCol = new double[array1.GetLength(1)];
    for(int i =0; i < array1.GetLength(1); i++)
    {
        int k = 0;
        for(k = 0 ; k < array1.GetLength(0); k++)
        {
            averageCol[i] += array1[k,i]; 
        }
        averageCol[i] = averageCol[i] / k;

    }
    return averageCol;

}

void result(double[] total)
{
    Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ",total)}.");
}

void printArray(int[,] arrayPrint)
{
    for(int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for(int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write(arrayPrint[i,j] + " ");
        }
        Console.WriteLine();
    }
        
}

Console.Clear();
fillArray(array);
double [] totalForPrint = averageColumn(array);
printArray(array);
result(totalForPrint);
Console.WriteLine("");