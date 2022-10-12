int num = int.Parse(Console.ReadLine());

if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Не день недели");
}