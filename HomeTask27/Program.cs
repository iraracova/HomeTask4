// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;

while(N > 0)
{
    result = result + N % 10;
    N = N / 10;
}
Console.WriteLine($"Результат = {result}");
