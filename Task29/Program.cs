﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
 */

int[] array = new int[8]; // 0 1 2 3 4 5 6 7

FillArray(array);
WriteArray(array);
WriteArray1(array);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 101);

    }




}

void WriteArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(arr[i] + " ");
        //Console.Write($" [{arr[i] + " " }]");

    }


}
void WriteArray1(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //Console.Write($" [{arr [i]} ]");
        //Console.Write($"{arr[arr.Lendth -1] } ");
        Console.Write($" {arr[i] + " "}");

    }
    Console.WriteLine(" ]");
}
