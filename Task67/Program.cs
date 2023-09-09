// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введит целое число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number) //453 -> 45 -> 4
{
    if (number == 0) return 0;
    return number % 10 + SumDigits(number / 10); // 453, 45 --> 4 --> 0
                                                 // 0 + 4 % 10 + 45 % 10 + 453 % 10
}


Console.WriteLine(SumDigits(number));

