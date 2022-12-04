// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Не использовать строки

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
Console.Write($"{message} >"); 
return Convert.ToInt32(Console.ReadLine()); 
}

int number = Prompt("Введите пятизначное число");

int A = number % 10;
int a = number / 10;

int B = A % 10;
int b = a / 10;

int C = B % 10;
int c = b / 10;

int D = C % 10;
int d = c / 10;

if (A == d && B == D)
{
    System.Console.WriteLine($"Число {number} палиндром");
}
else
{
    System.Console.WriteLine($"Число {number} не палиндром");
}