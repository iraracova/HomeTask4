// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// (вводим массив с клавиатуры (т. е. через консоль :) ))

int[] arr = new int[8];
for(int i = 0; i < arr.Length; i ++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");

for(int i = 0; i < arr.Length; i ++)
{
    Console.WriteLine(arr[i]);
}