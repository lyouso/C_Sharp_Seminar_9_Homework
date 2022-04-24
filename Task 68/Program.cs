/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(n,m) = 29 */

int a = 3;
int b = 2;
Console.Write("Значение функции Аккермана равно " + Aсkermann(a, b));

int Aсkermann(int m, int n)
{
    if (m==0) return n+1;
    else if (n == 0) return Aсkermann(m - 1, 1);
    else return Aсkermann(m - 1, Aсkermann(m, n-1));
}
