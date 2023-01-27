// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Введите первое число ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int B = int.Parse(Console.ReadLine()!);
if (A > B)
    Console.WriteLine($"max = {A}, min = {B}");
else
    Console.WriteLine($"max = {B}, min = {A}");
