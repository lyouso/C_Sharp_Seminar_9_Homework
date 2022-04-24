/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int m = 1;
int n = 15;
int sum = 0;
Console.WriteLine(Recursion(m, n));

int Recursion(int m, int n)
{
    if (n + 1 == m) return 0;
    sum += m;
    Recursion(m + 1, n);
    return sum;
}
