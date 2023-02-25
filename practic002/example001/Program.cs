Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int secondChar = numberA / 10 % 10;

Console.WriteLine(secondChar);
