// 2. Найти сумму элементов от M до N, N и M заданы.

int SumOfNumbers(int m, int n)
{
    if (n == m) return n;
    return m + SumOfNumbers(m + 1, n);
}
Console.WriteLine(SumOfNumbers(1, 10));
