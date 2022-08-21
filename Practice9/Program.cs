// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
}
double min = array[0];
double max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    
    min = array[i];

    if (array[i] > max)
    {
        max = array[i];
    }
    Console.Write(array[i] + " ");
}   
Console.WriteLine();
Console.WriteLine(max - min);

