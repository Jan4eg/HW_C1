﻿/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a;
int b;
int c;
int max = 0;
Console.Write("Введите первое число: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
c = int.Parse(Console.ReadLine());

if(a > max) max = a; 
if(b > max) max = b; 
if(c > max) max = c;

Console.Write(max);