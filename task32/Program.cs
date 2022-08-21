// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Введие количество элементов массива");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-99, 100);
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}
Console.WriteLine(string.Join(", ", array));