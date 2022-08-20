// Определить, присутствует ли в заданном массиве, некоторое число
int [] array = {2, 5, 7, 9, 12, 67, 86};
Console.WriteLine("Веведите число");
int n = int.Parse(Console.ReadLine() ?? "0" );
int m = array.Length;
int index = 0;
while (index < m)
{
 if(n == array[index])
 { 
    Console.WriteLine("Число " +n + " есть в массиве" );
    break;
 }
   index++;     
}
  
    Console.WriteLine("Числа нет в массиве: " );   
 