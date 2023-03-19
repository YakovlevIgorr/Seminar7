// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет

int [,] array = new int[3,4];

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

int inputNumber(string lineOrColumn)
{
    int number = 0;
    {
        Console.Write("Введите номер" + lineOrColumn);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

void printTotal(int line, int column)
{
    //string finishPhise = "";
    
    if(line > array.GetLength(0)-1 || column > array.GetLength(1)-1) 
    {
        Console.WriteLine($"{line} {column} -> такого числа в массиве нет");
    }else Console.WriteLine($"{line} {column} -> {array[line,column]}  ");
}

Console.Clear();
int [,] array1 = fillArray(array);
int inputLine = inputNumber(" строки ");
int inputColumn = inputNumber(" столбца ");
printArray(array1);
printTotal(inputLine,inputColumn);
Console.WriteLine("");