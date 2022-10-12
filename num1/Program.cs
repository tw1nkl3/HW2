Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if ((num >= 100 && num <= 999) | (num >= -999 && num <= -100))
{
    int temp = num / 10;
    //int secondDigit = temp % 10;
    Console.WriteLine("Вторая цифра: " + Math.Abs(temp % 10));
}
else
{
    Console.WriteLine("Неверный ввод");
}