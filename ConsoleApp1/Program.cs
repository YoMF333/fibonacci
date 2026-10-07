using System.Numerics;

Console.Write("n = ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
    Console.WriteLine("Введите неотрицательное целое число.");
    return;
}

Console.WriteLine(Fib(n));

static BigInteger Fib(int n)
{
    BigInteger a = 0, b = 1;
    for (int i = 0; i < n; i++)
    {
        (a, b) = (b, a + b);
    }
    return a;
}