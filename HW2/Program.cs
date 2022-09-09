// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SUM(int num1,int num2)
{
if (num1 == num2+1) return 0;
return (SUM(num1+1,num2)+num1);
}



Console.WriteLine("Задайте значение M ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(SUM(M,N));

