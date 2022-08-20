// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();
int[] array = new int[8];
int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write($"{array[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) even++;
    else odd++;
}
    Console.WriteLine($"Чётные числа: {even}");
    Console.WriteLine($"Нечётные числа: {odd}");
