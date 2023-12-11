/*Задача 1: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
4 3 1 (1,2) => 9
2 6 9 
*/
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int [,] twoDimArray = FillTwoDimArray(3,3);
Print(twoDimArray);


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
int Result(int [,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int num=0;
    if(number1<=rows && number2<=cols)
    {
    for(int i = 0;i<rows;i++)
    {
        for(int j = 0;j<cols;j++)
        {
           if(i==number1 && j == number2 )
           {
            num = array[i,j];
           }
           
        }
    }
    }else Console.WriteLine("");
    
    return num;
 }
 Console.WriteLine(Result(twoDimArray));