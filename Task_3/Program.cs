
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Random random = new Random();
for (int i = 0; i < 8; i++)
{
    array[i] = random.Next(9);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();