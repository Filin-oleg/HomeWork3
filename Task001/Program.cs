// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
string str = (Console.ReadLine());
if (str.Length != 5) {Console.WriteLine("Вы ввели не пятизначное число");}
else
{
    if (str[0] == str[4] && str[1] == str[3])
    { Console.WriteLine("Данное число является полиндромом"); }
    else { Console.WriteLine("Данное число не является полиндромом"); }
}