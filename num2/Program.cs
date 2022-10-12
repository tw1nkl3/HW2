int num = int.Parse(Console.ReadLine());

if (num >= 100)
{
    string temp =  Convert.ToString(num);
    Console.WriteLine("3-ья цифра: " + temp[2]);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}