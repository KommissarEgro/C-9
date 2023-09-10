// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine($"M = {numberM},N ={numberN} -> {SumNumMN(numberM, numberN)}");
 
if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Число должно быть больше 0");
    return;
}

int SumNumMN(int m, int n)
{
    if (m < n) return n + SumNumMN(m,n-1);
    else if (m > n) return n + SumNumMN(m,n+1);
    else return m;
}
