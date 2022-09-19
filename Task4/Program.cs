/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] GetArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * ((1000) - (-1000)) + (-1000);
    }
    return array;
}

double MinNumber (double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double MaxNumber (double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double GeSubtractionMaxMin (double max, double min)
{
    double subtraction = 0;
    if(max >= 0)
    {
        subtraction = max - min;
    }
    if(max < 0)
    {
        subtraction = Math.Abs(min) - Math.Abs(max);
    }
    return subtraction;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

try{
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(size);

Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();

double min = MinNumber(array);
Console.WriteLine($"Минимальное число в массиве: {min}");


double max = MaxNumber(array);
Console.WriteLine($"Макусимальное число в массиве: {max}");

double result = GeSubtractionMaxMin(max, min);
Console.WriteLine($"Разница между максимальным и минимальным числом = {result}");
}
catch
{
    Console.WriteLine("Ошибка! Неверный ввод размера массива! Введите целое число.");
}

