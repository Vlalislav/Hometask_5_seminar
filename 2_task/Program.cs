/*Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д*/

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
int [,] twoDimArray = FillTwoDimArray(3,3);
Print(twoDimArray);
Console.WriteLine($" = {PlusLine(twoDimArray)} ");
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
int PlusLine (int [,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int summ =0;
    for(int i = 0;i<rows;i++)
    {
        for(int j = 0;j<cols;j++)
        {
           if(i == j)
           {
            summ = summ + array[i,j];
            Console.Write(array[i,j] + " ");
            
           }
        }
        
    }return summ;
}