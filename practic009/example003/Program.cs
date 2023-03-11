int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"НОД = {GreatestCommonFactor(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int GreatestCommonFactor(int m, int n)
{
    if (n == 0)
        return m;
    else 
        return GreatestCommonFactor(n, m % n);
}
