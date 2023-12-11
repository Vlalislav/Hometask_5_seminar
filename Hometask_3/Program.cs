/*Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.*/
int [,] twoDimArray = FillTwoDimArray(3,3);
Print(twoDimArray);
Console.WriteLine(Smaller(twoDimArray));
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
 int Smaller (int [,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int min = 10;
    int number =0;
    for(int i = 0;i<rows;i++)
    {
        int probe = 0;
        for(int j = 0;j<cols;j++)
        {
           probe = probe + array[i,j];
        }
        if (min>probe)
        {
            min = probe;
            number = i;
        }
    }
    return number;
 }