Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}

else if (number < 1 || number >7)
{
    Console.WriteLine("Нет такого дня");
}
else 
{
    Console.WriteLine("Нет");
}