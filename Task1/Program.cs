/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetArray()
{
    int[] array = new int[3];
    for(int i=0; i<3; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

int PositiveCount(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

int[] array = GetArray();

Console.WriteLine("Задан массив: ");
PrintArray(array);
Console.WriteLine();

int count = PositiveCount(array);
Console.WriteLine($"Количество четных чисел в массиве = {count}");
