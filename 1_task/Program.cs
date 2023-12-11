/*Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.*/
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace task_01
{
    public static class Program
    {
        public static void Main (string[] args){
            int [,] twoDimArray = CreateTwoDimArray(3,3,1,9);
            Console.WriteLine("Init array");
            Print(twoDimArray);
            Console.WriteLine("MOd array");
            Print(ModArray(twoDimArray));
        }
        public static int [,] CreateTwoDimArray(int rows, int cols,int min , int max){
            int [,] twoDimArray = new int [rows,cols];
            Random rand = new();
            for(int i = 0; i<rows;i++)
            {
                for(int j = 0 ; j< cols;j++)
                {
                    twoDimArray[i,j] = rand.Next(min,max+1);
                }
            }

            return twoDimArray;
        }
        public static void Print(int[,]array){
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for(int i =0; i<rows;i++)
            {
                 for(int j =0; j<cols;j++)
                 {
                    Console.Write(array[i,j] + "\t" );
                 }Console.WriteLine();
            }
        }
        public static int [,] ModArray( int [,] array){
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for(int i =0; i<rows;i++)
            {
                 for(int j =0; j<cols;j++)
                 {
                    if(i % 2 == 0 && j % 2 == 0)
                    {
                        array[i,j] = (int)Math.Pow(array[i,j],2);
                    }
                    
                 }
            }
            return array;
        }
        
    }
}