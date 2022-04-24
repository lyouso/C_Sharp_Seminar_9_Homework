/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9"
M = 13; N = 20. -> "15, 18" */
Recursion(1, 9);

void Recursion(int n, int m)
{

        if (m + 1 == n) return;
        if (n%3 == 0)
        {
            Console.Write(n + " ");
        }
        Recursion(n + 1, m);

    
        
    
    


}