// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
Console.Write($"{message} >"); 
return Convert.ToInt32(Console.ReadLine()); 
}
int X = Prompt("X =");
int Y = Prompt("Y =");
int Z = Prompt("Z =");

int x = Prompt("X 2 =");
int y = Prompt("Y 2 =");
int z = Prompt("Z 2 =");

int rezx = x - X;
int rezy = y - Y;
int rezz = z - Z;
double S = Math.Sqrt(rezx*rezx+rezy*rezy+rezz*rezz); 

System.Console.WriteLine($"Расстояние = {S:F2}");