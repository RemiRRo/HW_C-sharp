Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
string thirdChar = numberA.ToString();

if (numberA > 99) {
    Console.WriteLine(thirdChar[2]);
} else {
    Console.WriteLine("Третьей цифры нет");
}
