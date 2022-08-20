// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = { 0, 4, 8, -5, -9, 3, -6, -3, 2, 6, -7, -2 };
int sumpos = 0;
int sumneg = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    {
        sumpos += array[i];
    }
    else
    {
        sumneg += array[i];
    }
Console.WriteLine("Сумма положительных чисел: " + sumpos);
Console.WriteLine("Сумма отрицательных чисел: " + sumneg);