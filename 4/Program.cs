/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N;
int N0 = 1;

Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine(), out N);

while(N0 < N)
{
Console.Write(N0); 
Console.Write(", ");
N0++;
}
Console.Write(N);