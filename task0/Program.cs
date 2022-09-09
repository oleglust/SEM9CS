// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//func
// void posledovatelnost (int N)
// {
//   for (int i = 1; i < N+1; i++)
//   {
//     Console.Write(i +", ");
//   }
// }
// int posledovatelnost (int numbers)
// {
//     if (numbers != 1) Console.Write(posledovatelnost(numbers-1) +" ");
//     return numbers;
// }
Console.WriteLine("Задайте значение N ");
int N = int.Parse(Console.ReadLine());

string Print(int N)
{
string s = "";
if (N == 0) return s;
return (Print(N-1)+N).ToString();
}

Console.WriteLine(Print(N));
//code
// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine());
// posledovatelnost(N);
