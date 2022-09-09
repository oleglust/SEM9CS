//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии.

int STEPN(int num1,int num2)
{
if (num2 == 0) return 1;
return (STEPN(num1,num2-1)*num1);
}

Console.WriteLine("Задайте значение A ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение B ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Abs(STEPN(A,B)));



