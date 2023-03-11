int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
if (n < 1 || m < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
if (m < n) {
    Console.WriteLine(NaturalNumber(m, n));
} else {
    Console.WriteLine(NaturalNumber(n, m));
}

int NaturalNumber(int m, int n)
{
    if (n == m)
        return n;
    if (m < n && n % 2 == 0)
        Console.WriteLine(n);
        return NaturalNumber(m, n - 1);
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}