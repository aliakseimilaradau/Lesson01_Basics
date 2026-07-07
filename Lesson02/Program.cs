Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Как тебя зовут?");
string userName = Console.ReadLine();

Console.WriteLine($"Привет, {userName}");

Console.WriteLine("Сколько тебе лет?");
string ageInput = Console.ReadLine();

int userAge = int.Parse(ageInput);

if (userAge < 18)
{
    Console.WriteLine("Ты несовершенолетний");
}
else if (userAge <= 65)
{
    Console.WriteLine("Ты совершенолетний");
}
else
{
    Console.WriteLine("Ты можешь выйти на пенсию");
}