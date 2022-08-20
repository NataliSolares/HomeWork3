// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = { 3, 29, 18, 83, 2, 98, 1, 16, 7, 34 };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}
Console.WriteLine(" ");
int f = array.Length - 1;
for (int i = 0; i < (array.Length) / 2; i++)
{
    Console.Write($" {array[i] * array[f]}");
    f--;
}