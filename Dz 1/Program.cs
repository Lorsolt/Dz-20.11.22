// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int answer = num1;

for (int i = 1; i < num2; i++)
{
    answer = answer * num1;
}
Console.WriteLine($"{num1} в степени {num2} равно: " + answer);git