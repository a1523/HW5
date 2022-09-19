// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний эл-т, второй 
//и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        array[i]= new Random().Next(-100, 100);
    }
    return array;
}


int[] GetNewArray(int[] array)
{
    if(array.Length%2 == 0)
    {
        int [] arrayNew = new int[array.Length/2];
        for(int i=0; i<arrayNew.Length; i++)
        {
            arrayNew[i] = array[i] * array[array.Length-i-1];
        }
        return arrayNew;
    }
    
    else
    {
        int [] arrayNew = new int[array.Length/2+1];
        for(int i=0; i<=arrayNew.Length-2; i++)
        {
            arrayNew[i] = array[i] * array[array.Length-i-1];
            
        }
        arrayNew [arrayNew.Length-1] = array[array.Length/2];
        return arrayNew;
    }
}

void PrintArray (int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}


Console.WriteLine("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine());
Console.WriteLine("Старый массив: ");
int[] array =  GetArray(arrayLength);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
int [] arrayNew = GetNewArray(array);
PrintArray(arrayNew);