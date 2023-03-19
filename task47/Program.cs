// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// ​0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// ​8 7,8 -7,1 9

double [,] array = new double[3,4];

double [,] fillArray(double [,] arrayForFill)
{
    for(int i = 0; i < arrayForFill.GetLength(0); i++)
    {
        for(int j = 0; j < arrayForFill.GetLength(1); j++)
        {
            arrayForFill[i,j] = (Random.Shared.NextDouble() * 20) - 10;
        }
    }
    return arrayForFill;

}
void printArray(double [,] arrayPrint)
{
    for(int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for(int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write(double.Round(arrayPrint[i,j], 1) + "  ");
        }
        Console.WriteLine();
    }
        
}
double [,] fillArray2 = fillArray(array);
printArray(fillArray2);
