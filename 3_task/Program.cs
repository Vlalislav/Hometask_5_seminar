/*Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива*/
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
 int [] NewArray( int[,]array)
 {
    int box = 0;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int [] newarray = new int [rows];
    for(int i = 0;i<rows;i++)
    {
        for(int j = 0;j<cols;j++)
        {
           box = box+ array[i,j];
        }
        newarray[i]=box/cols;
        box = 0;
    }
    return newarray;
 }
int [,] twoDimArray = FillTwoDimArray(3,3);
Print(twoDimArray);
Console.WriteLine(string.Join(", ",NewArray(twoDimArray)));