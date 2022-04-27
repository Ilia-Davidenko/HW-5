// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = PrintArray(15, 100, 1000);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(Even(array));

int[] PrintArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int Even(int[] array)
{
    int count = 0;

    foreach (int i in array)
    {
        count += (i % 2 == 0) ? 1 : 0;
    }
    Console.WriteLine($"Колличество четных чисел в массиве {count}");
    return count;
}