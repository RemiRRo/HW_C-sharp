// task 2
Console.WriteLine("Введите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA > numberB ? numberA : numberB;

Console.WriteLine("Max value: " + max);
