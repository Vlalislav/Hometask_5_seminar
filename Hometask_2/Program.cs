/*Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.*/
int [,] twoDimArray = FillTwoDimArray(3,3);
Print(twoDimArray);
int[,] newArray = NewArray(twoDimArray);
Console.WriteLine();
Print(newArray);
int [,] FillTwoDimArray(int rows, int cols)
{
    int [,] twoDimArray = new int[rows,cols];
    Random rand = new();
    for(int i = 0;i<rows;i++)
    {
        for(int j = 0;j<cols;j++)
        {
            twoDimArray[i,j] = rand.Next(0,10);
        }
    }
return twoDimArray;
}
void Print(int [,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for(int i = 0;i<rows;i++)
    {
        for(int j = 0;j<cols;j++)
        {
           Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
 }
 int [,] NewArray(int [,] array)
 {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for(int i = 0;i<cols;i++)
        {
            int temp = array[0,i];
            array[0,i]=array[rows-1,i];
            array[rows-1,i] = temp;
        }
        return array;
 }
