﻿int size = new Random().Next(1, 11);

Console.WriteLine($"Количетсов элементов массива: {size}");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
}

PrintDiffMinMax(FillSourceArray(size));
