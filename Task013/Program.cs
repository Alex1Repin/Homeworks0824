Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string NumberArray = Convert.ToString(number);
int length = NumberArray.Length;

if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(NumberArray[2]);
}