// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//func

// int posledovatelnost (int numbers)
// {
//     if (numbers != 1) Console.Write(posledovatelnost(numbers-1) +" ");
//     return numbers;
// }
Console.WriteLine("Задайте значение N ");
int N = int.Parse(Console.ReadLine());

int SUM(int N1)
{
if (N1 == 0) return N1;
else
{
   
    return (SUM(N1/10)+N1%10);// в первую очередь прибавляется остаток от деления
}
}


Console.WriteLine(Math.Abs(SUM(N)));//модуль числа!
//code
// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine());
// posledovatelnost(N);
