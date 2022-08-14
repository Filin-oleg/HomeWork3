// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до введенного Вами числа");
for (int i = 1; i <= num; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine(cube);
}