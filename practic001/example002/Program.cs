//task 4
Console.WriteLine("Введите три числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberThree = Convert.ToInt32(Console.ReadLine());

int max = numberA > numberB ? (numberA > numberThree ? numberA : numberThree) : (numberB > numberThree ? numberB : numberThree);

Console.WriteLine("Max value: " + max);
