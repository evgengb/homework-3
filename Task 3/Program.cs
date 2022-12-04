// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
Console.Write($"{message} >"); 
return Convert.ToInt32(Console.ReadLine()); 
}

int number = Prompt("Значение =>");
int start = 1;
int mod = number; 

if(mod<0)
{
    mod= -mod;
}

while (start <= mod) 
{
    int square = start*start*start;
    System.Console.WriteLine(square);
    start++;
}