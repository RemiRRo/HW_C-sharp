//task 6 
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberA; i++) 
{
    if (i % 2 == 0) 
    {
        Console.WriteLine(i);
    }
}