﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int res = 1;

for (int i = 0; i < b; i++)
{
    res = res * a;
}
Console.WriteLine($"{a},{b} -> {res}");
