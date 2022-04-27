// SЗадача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] array = PrintArray();
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(MinMAx(array));


int[] PrintArray()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int MinMAx(int[] array)
{
    int minValue = array[0];
    int maxValue = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (minValue > array[i]) minValue = array[i];
        if (maxValue < array[i]) maxValue = array[i];
    }
    Console.WriteLine($"max {maxValue}, min {minValue}");
    int diff = maxValue - minValue;
    return diff;
}