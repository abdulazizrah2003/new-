﻿string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];

void SecondArrayAddIf (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray (string[] array)
{
    for (int i = 0;i<array.Length ;i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

SecondArrayAddIf (array1, array2);
PrintArray (array2);