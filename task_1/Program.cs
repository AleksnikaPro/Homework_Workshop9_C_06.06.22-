// 1. Показать натуральные числа от M до N, N и M заданы.

void ShowNumber(int m, int n)
{
    if (n < m) return;
    ShowNumber(m, n - 1);
    Console.Write(n + " ");
}
ShowNumber(20, 35);