// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите  первое число от нуля до 4: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число от нуля до 11: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 4 || numberN > 11) Console.Write("Некорректный ввод.");
if (numberM == 4 && numberN >= 1) Console.Write("При введенном первом числе равном 4, второе введенное число не должно привышать 0.");

Console.Write($"m = {numberM}, n = {numberN} -> A(m,n) = {Ack(numberM,numberN)}");

int Ack(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0 && m > 0) return Ack(m -1,1);
else return (Ack(m -1,Ack(m,n-1)));
}

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// // вызов функции Аккермана
// void AkkermanFunction(int m, int n)
// {
// Console.Write(Akkerman(m, n));
// }

// // функция Аккермана
// int Akkerman(int m, int n)
// {
// if (m == 0)
// {
// return n + 1;
// }
// else if (n == 0 && m > 0)
// {
// return Akkerman(m - 1, 1);
// }
// else
// {
// return (Akkerman(m - 1, Akkerman(m, n - 1)));
// }
// }