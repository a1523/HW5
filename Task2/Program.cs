/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

int GetSummUneven (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

try
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = GetArray(size);

    Console.WriteLine("Массив: ");
    PrintArray(array);
    Console.WriteLine();

    int countUneven = GetSummUneven(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {countUneven}");
}

catch
{
    Console.WriteLine("Ошибка! Неверный ввод размера массива! Введите целое число.");
}