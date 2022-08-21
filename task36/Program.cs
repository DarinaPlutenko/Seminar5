// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine($"Введите количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numbers, int min, int max)
{
    int[] randomNumbers = new int[numbers];
    int sum = 0;
    Console.WriteLine("Получившийся массив случайных чисел: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sum = sum + randomNumbers[i];
        }
    }
    return sum;
}

int randomNumbers = RandomNumbers(numbers, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");