// Написать программу замену элементов массива на противоположные
int[] array = { 0, 4, 8, -5, -9, 3, -6, -3, 2, 6, -7, -2 };
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.WriteLine(array[i] + " ");
}
