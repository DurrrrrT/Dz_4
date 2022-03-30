// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;

for (int i = 1; i <= B; i++)
{
    C = C * A;
}
System.Console.WriteLine(C);

