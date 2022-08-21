// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {6, 7, 3, 6};
Console.WriteLine($"Задан массив:");
Console.WriteLine(string.Join(", ", array));

int[] resArray = new int[(array.Length + 1) / 2];

for (int i = 0; i < resArray.Length; i++)
{
    resArray[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 != 0)
{
    resArray[resArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine("Произведение пар чисел массива:");
Console.WriteLine(string.Join(", ", resArray));