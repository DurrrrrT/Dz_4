// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введите число ");
// string number = Console.ReadLine();
// Console.WriteLine(number.Length);



System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
void Length(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    System.Console.WriteLine(count);
}
Length(number);
