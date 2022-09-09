// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Задайте значение min ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение max ");
int N2 = int.Parse(Console.ReadLine());


string Print(int max,int min)
{
string s = "";
if (max == min-1) return s;
return (Print(max-1, min)+max+" ").ToString();
}

Console.WriteLine(Print(N2, N1));

