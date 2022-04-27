// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = PrintArray();
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(SumOdd(array));

int[] PrintArray()
{
    int[] arr = new int[6];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 20);
    }
    return arr;
}

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}