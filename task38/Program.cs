// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76

double[] arrayReal = new double[10];
for (int i = 0; i < arrayReal.Length; i++)
{
    arrayReal[i] = new Random().Next(1, 10);

    Console.Write(arrayReal[i] + " ");
}

double max = arrayReal[0];
double min = arrayReal[0];

for (int i = 1; i < arrayReal.Length; i++)
{
    if (max < arrayReal[i])
    {
        max = arrayReal[i];
    }
    if (min > arrayReal[i])
    {
        min = arrayReal[i];
    }
}

double decision = max - min;

Console.WriteLine($"\nразница между между максимальным ({max}) и минимальным ({min}) элементами: {decision}");